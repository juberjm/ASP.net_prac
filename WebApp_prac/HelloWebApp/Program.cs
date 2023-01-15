using automobiles;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var fav_bike= new bike(){number=1,Name="suzuki",speed=220,price=541541,specifications="superBike"};
var bikeList=new List<bike>();

bikeList.Add(new bike(){number=1,Name="yamaha",speed=190,price=123451,specifications="youth speacial"});
bikeList.Add(new bike(){number=2,Name="bullet",speed=200,price=453451,specifications="royality"});
bikeList.Add(new bike(){number=9,Name="KTM",speed=230,price=653451,specifications="newbee"});
bikeList.Add(new bike(){number=4,Name="rajdoot",speed=170,price=156465,specifications="oldest beast"});

app.MapGet("/", () => "Hello World!  bikes=list   fav_bike");
app.MapGet("/bikes", () => bikeList);
app.MapGet("/fav_bike", () => fav_bike);


app.Run();
