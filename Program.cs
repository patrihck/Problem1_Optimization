using Problem1_Optimization.Logic;
using Problem1_Optimization.Logic.Utils;
using System.Diagnostics;

// Testing scenario
//var stopwatch = new Stopwatch();
//stopwatch.Start();
//var dataReader = new Problem1DataReader();
//var dataModel1 = dataReader.GetProblem1DataModelFromFile(DataReaderConstants.TinyExamplePath);
//Console.WriteLine($"First file loaded in {stopwatch.ElapsedMilliseconds}");
//stopwatch.Reset();

//stopwatch.Start();
//var dataModel2 = dataReader.GetProblem1DataModelFromFile(DataReaderConstants.SmallExamplePath);
//Console.WriteLine($"Second file loaded in {stopwatch.ElapsedMilliseconds}");
//stopwatch.Reset();

//stopwatch.Start();
//var dataModel3 = dataReader.GetProblem1DataModelFromFile(DataReaderConstants.MediumExamplePath);
//Console.WriteLine($"Third file loaded in {stopwatch.ElapsedMilliseconds}");
//stopwatch.Reset();

//stopwatch.Start();
//var dataModel4 = dataReader.GetProblem1DataModelFromFile(DataReaderConstants.BigExamplePath);
//Console.WriteLine($"Fourth file loaded in {stopwatch.ElapsedMilliseconds}");
//stopwatch.Reset();

//stopwatch.Start();
//var dataModel5 = dataReader.GetProblem1DataModelFromFile(DataReaderConstants.BiggerExamplePath);
//Console.WriteLine($"Fifth file loaded in {stopwatch.ElapsedMilliseconds}");
//stopwatch.Reset();
//Console.ReadKey();


var dataReader = new Problem1DataReader();
var dataModel = dataReader.GetProblem1DataModelFromFile(DataReaderConstants.TinyExamplePath);

var dataSorter = new Problem1DataSorter();
dataSorter.SortByColumn(dataModel, 0);

var dataWriter = new Problem1DataWriter();
dataWriter.WriteData("Input\\TinyExample-Sorted.txt", dataModel);

var dataIndexer = new Problem1DataIndexer();
var indexes = dataIndexer.GetIndexesOfRowsWithDoubledColumns(dataModel.Rows, 0, 1);

var dataConverter = new Problem1DataConverter();
var finalDataModel = dataConverter.ConvertToValuesAndIndexesOfDoubledColumns(dataModel, indexes);
dataWriter.WriteData("Input\\FinalTinyExample.txt", finalDataModel);
Console.ReadKey();
