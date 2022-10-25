/*

ARELY MARTINEZ 
OCT 24, 2022 5:02 PM 
MINI CHALLANGE #1
WELL CREATE MULTIPLE ROUTES AND METHOS ONE FOR 
EACH MINI CHALLANGE. IN PROGRAM YOULL BE ABLE TO 
CALL OUT BY ENTERING IN THE ROUTE NAME. EXAMPLE:
https://localhost:7274/new/SAYHELLO THIS WILL
 RESPOND WITH - HELLO ARELY GOOD EVENING!!

PEER REVIEW: Aisha Mashrah Everything seems to 
work. The methods were the correct names and 
there was a full discription of what was going 
on. The flowchart looks neat and represents the 
code too.

*/

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
