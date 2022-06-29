﻿using StrategyPattern.Strategies;
using StrategyPattern.Services;
using StrategyPattern.Models;
using StrategyPattern.Client;


var root = JsonToModelService.Deserialize("Files/sample.json");
var context = new Context();
var client = new SearchClient(context);
var dfsResult = client.ExecuteSearch(10, root, StrategyEnum.DFS);
var bfsResult = client.ExecuteSearch(10, root, StrategyEnum.BFS);

Console.WriteLine(dfsResult.Id);
Console.WriteLine(bfsResult.Id);
