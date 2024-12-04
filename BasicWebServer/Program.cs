Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(webBuilder =>
    {
        webBuilder.Configure(app =>
        {
            app.Run(async context =>
            {
                //blocking code
                //Task.Delay(2000).Wait();
                //non-blocking code
                await Task.Delay(2000);
                await context.Response.WriteAsync("Hello world!");
            });
        });
    })
    .Build()
    .Run();