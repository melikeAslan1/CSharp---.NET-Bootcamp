//buras� ilk a�ama �antaya malzemeleri koymak gibi. i�lemleri haz�rla yani. hangi nesnelerle i� yap�caksam builder.Services diyerek onlar�n nesnelerini ekliyorum.
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(opt => opt.AddPolicy("AllowAll", p =>  //ekledik.
{
    p.AllowAnyOrigin();
    p.AllowAnyMethod();
    p.AllowAnyHeader();
}));





// buras� 2.a�ama yani requestten gelen her talepte yap�lacak i�lemleri belirtiyoruz.
// use ile ba�layan her�ey seri imalattaki bir i�lem gibi d���nebiliriz.
// bunlar�n s�ras� da �nemli.

var app = builder.Build();

app.UseWelcomePage();  // bu sat�r� yazarak b�t�n requestleri buraya y�nlendirdik.


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

