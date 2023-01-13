using BoardWebApp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;

namespace BoardWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            // Db���� �߰�
            builder.Services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(
               builder.Configuration.GetConnectionString("DBConnection")
               ));

			// ASPNET Identity�� ���� �߰�
			builder.Services.AddIdentity<IdentityUser, IdentityRole>()
				.AddEntityFrameworkStores<ApplicationDbContext>()
				.AddDefaultTokenProviders();

            // �н����� ��å ���� ����
            builder.Services.Configure<IdentityOptions>(
                opt =>
                {
                    opt.Password.RequiredLength = 4; // �ּ� ��ȣ ����
                    opt.Password.RequireNonAlphanumeric = false; // Ư������
                    opt.Password.RequireDigit = false;     // ������
                    opt.Password.RequireLowercase = false; // �ҹ���
                    opt.Password.RequireUppercase = false; // �빮��
                }
            );

            // ���� ����
            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminRolePolicy", policy => policy.RequireRole("Admin"));
            });

            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("EditRolePolicy", policy => policy.RequireRole("Edit Role"));
				options.AddPolicy("DeleteRolePolicy", policy => policy.RequireRole("Delete Role"));
			});

			var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication(); // �������� �������

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}