using Microsoft.EntityFrameworkCore.Metadata.Internal;
using razor_demo.Data;
using System;

namespace razor_demo.NewFolder
{
    public class CatagoryData
    {
        private readonly AppDbContext _context;

        public CatagoryData(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateCategoryAsync<T>(int company_id) where T : class
        {
            _context.OfitCategory.AddRange(
                new OfitCategory
                {
                    Name = "Vật tư",
                    IsActive = true,
                    Type = CategoryType1.Material,
                    Description = "Danh sách vật tư",
                    Sequence = 0,
                    CompanyId = company_id // Sử dụng company_id nếu cần
                },

                new OfitCategory
                {
                    Name = "Công cụ",
                    IsActive = true,
                    Type = CategoryType1.Tool,
                    Description = "Danh sách vật tư",
                    Sequence = 1,
                    CompanyId = company_id
                },
                new OfitCategory
                {
                    Name = "Cây trồng",
                    IsActive = true,
                    Type = CategoryType1.Crop,
                    Description = "Danh sách cây trồng",
                    Sequence = 2,
                    CompanyId = company_id
                },
                new OfitCategory
                {
                    Name = "Sản phẩm",
                    IsActive = true,
                    Type = CategoryType1.Product,
                    Description = "Danh sách sản phẩm",
                    Sequence = 3,
                    CompanyId = company_id
                },
                new OfitCategory
                {
                    Name = "Hoạt động",
                    IsActive = true,
                    Type = CategoryType1.Activity,
                    Description = "Danh sách đơn vị",
                    Sequence = 4,
                    CompanyId = company_id
                },
                new OfitCategory
                {
                    Name = "Khác",
                    IsActive = true,
                    Type = CategoryType1.Unit,
                    Description = "Khác",
                    Sequence = 5,
                    CompanyId = company_id
                }
            );

            // Lưu thay đổi vào cơ sở dữ liệu
            await _context.SaveChangesAsync();
        }
    }
}
