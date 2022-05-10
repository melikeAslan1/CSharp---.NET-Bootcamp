var builder = WebApplication.CreateBuilder(args);

// Add services to the container.




// bu k�s�mda Api de ihtiya� duydu�umuz nesneler olu�turuluyor. Yani �antay� malzemeleri haz�rla k�sm�. 
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// ne istiyorsak onu buradan builder a ekliyoruz. 

builder.Services.AddCors(opt => opt.AddPolicy("AllowAll", p =>
{
    p.AllowAnyOrigin();
    p.AllowAnyMethod();
    p.AllowAnyHeader();
}));




// bu k�s�m http protokol� arac�l��� ile istemci den gelen her talebte yap�lacak i�lemleri belirtir.
// Yani bu k�s�m i�e ba�la k�sm�, i�i yap k�sm�.
// bu i�lemlerin bir s�ras� var.
// middleware bir API ye gelen b�t�n requestlerin ba��na gelecek her�eyin y�netilebilmesi i�in kullan�lan yap�d�r.
var app = builder.Build();
//app.UseWelcomePage();
// Configure the HTTP request pipeline.


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowAll");
app.UseAuthorization();


app.MapControllers();

app.Run();

