using MyWebApiApp.Models;

namespace MyWebApiApp.Services
{
    public interface IHangHoaRepository
    {
        List<HangHoaModel> GetAll(string? search, double? from, double? to, string? sortBy, int page = 1);
    }
}
