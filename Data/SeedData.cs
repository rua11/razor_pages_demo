using Microsoft.EntityFrameworkCore;
using System;

namespace razor_demo.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                //context.Database.EnsureCreated();

                // Kiểm tra nếu dữ liệu đã tồn tại
                if (context.OfitCategory.Any(c => c.CompanyId == null))
                {
                    return;   // Dữ liệu đã được khởi tạo
                }

                context.OfitCategory.AddRange(
                    new OfitCategory
                    {
                        Name = "Vật tư",
                        IsActive = true,
                        Type = CategoryType1.Material,
                        Description = "Danh sách vật tư"
                    },
                    new OfitCategory
                    {
                        Name = "Công cụ",
                        IsActive = true,
                        Type = CategoryType1.Tool,
                        Description = "Danh sách vật tư"
                    },
                    new OfitCategory
                    {
                        Name = "Cây trồng",
                        IsActive = true,
                        Type = CategoryType1.Crop,
                        Description = "Danh sách cây trồng"
                    },
                    new OfitCategory
                    {
                        Name = "Sản phẩm",
                        IsActive = true,
                        Type = CategoryType1.Product,
                        Description = "Danh sách sản phẩm"
                    },
                    new OfitCategory
                    {
                        Name = "Hoạt động",
                        IsActive = true,
                        Type = CategoryType1.Activity,
                        Description = "Danh sách đơn vị"
                    },
                    new OfitCategory
                    {
                        Name = "Khác",
                        IsActive = true,
                        Type = CategoryType1.Unit,
                        Description = "Khác"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
