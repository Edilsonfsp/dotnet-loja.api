using infra.data.efcore;
using loja_api.endpoints.customer;
using loja_api.endpoints.seller;
using loja_api.infra.data.customer;
using loja_api.infra.data.efcore;
using loja_api.infra.data.seller;
using loja_api.services;
using loja_api.services.handlers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var service = builder.Services;
var configuration = builder.Configuration;

service.AddTransient<ISellerRequest, SellerRequestWithEfCore>();
service.AddTransient<ICustomerRequest, CustomerRequestWithEfCore>();
service.AddTransient<IAdminService, DefaultAdminService>();

service.AddDbContext<ApplicationDbContext>(
	options => options.UseMySql(configuration["dataDase:mySqlString"],
	Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.25-mysql"))
	);

service.AddEndpointsApiExplorer();
service.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Customers Endpoints
app.MapMethods(CustomerPost.Template, CustomerPost.Methods, CustomerPost.Handle);
app.MapMethods(CustomerGetAll.Template, CustomerGetAll.Methods, CustomerGetAll.Handle);
app.MapMethods(CustomerPut.Template, CustomerPut.Methods, CustomerPut.Handle);


//Sellers Endpoints
app.MapMethods(SellerPost.Template, SellerPost.Methods, SellerPost.Handle);
app.MapMethods(SellerGetAll.Template, SellerGetAll.Methods, SellerGetAll.Handle);
app.MapMethods(SellerPut.Template, SellerPut.Methods, SellerPut.Handle);



app.Run();