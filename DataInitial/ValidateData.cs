using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using razor_demo.Data;
using System.Xml.Linq;

namespace razor_demo.DataInitial
{
    public class ValidateData
    {
        private readonly AppDbContext _context;

        public ValidateData(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CheckDuplicateNameAsync<T>(string name, int id) where T : class
        {
            // Sử dụng AnyAsync để kiểm tra trùng tên một cách bất đồng bộ
            var check_duplicate = await _context.Set<T>().AnyAsync(c =>
            EF.Property<string>(c, "Name") == name &&
            EF.Property<int>(c, "Id") != id);
            return check_duplicate;
        }

        public async Task<int> GetNextSequenceAsync<T>() where T : class
        {
            // Lấy giá trị lớn nhất của Sequence hiện có (nullable int)
            int maxSequence = await _context.Set<T>().MaxAsync(c => (int?)EF.Property<int>(c, "Sequence")) ?? 0;
            return maxSequence + 1;
        }
    }
}
