var builder = DistributedApplication.CreateBuilder(args);

var sql = builder
    .AddSqlServer("sql")
    .AddDatabase("sqldata");

builder
    .AddProject<Projects.AspireSqlEfCore_AppHost>("aspiresql")
    .WithReference(sql);

builder
    .Build()
    .Run();
