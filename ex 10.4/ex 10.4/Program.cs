using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_10._4
{
    class Film
    {
        public string FilmId { get; set; }
        public string FilmName { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return FilmId + ":" + ":" + Price;
        }
        class Program
        {
            static void Main(string[] args)
            {
                int[] Numbers = { 7, 9, 3, 5, 2, 1, 0, 6, 4, 3, 1 };
                string[] Words =
                {"Chi","trich","phe", "phan", "nguoi","khac",
                    "giong","nhu","con","chim","bo","cau","dua","thu",
                    "bao", "gio","cung", "quay","ve","noi","xuat", "phat"
};
                List<Film> ListFilm = new List<Film>()
{
                new Film{FilmId="F01",FilmName="Diep vien 007",Price=120000},
                new Film{FilmId="F02",FilmName="Tam quoc dien nghia",Price=130000},
                new Film{FilmId="F03",FilmName="Thieu lam truyen ky",Price=16000},
                new Film{FilmId="F04",FilmName="Nguoi nhen 2",Price=100000},
                new Film{FilmId="F05",FilmName="Ngan hang tinh yeu",Price=340000},
                new Film{FilmId="F06",FilmName="Nguoi dep va quai thu",Price=230000},
                new Film{FilmId="F07",FilmName="Biet dong Sai Gon",Price=190000},
};
                IEnumerable<int> querynumber = Numbers.Where(n => n % 2 == 0);
                Show<int>(querynumber, "Loc cac so chan:");

                IEnumerable<string> queryword = Words.Where(w => w.Length > 4);
                Show<string>(queryword, "Loc cac tu co do dai >4:");

                IEnumerable<string> queryT = Words.Where(w => w.StartsWith("t"));
                Show<string>(queryT, "Loc cac tu co ten bat dau bang chu t:");

                var uniqueNumber = Numbers.Distinct();
                Show<int>(uniqueNumber, "Loc cac so duy nhat trong tap cac so:");

                var countDistinct = Words.Distinct().Count();
                Console.WriteLine("Dem xem co bao nhieu tu khong trung nhau:" +
                countDistinct);

                var fourNumber = Numbers.Take(4);
                Show<int>(fourNumber, "Lay 4 so dau tien trong day:");

                var twoword = Words.Take(2);
                Show<string>(twoword, "Lay 2 tu dau tien trong cau:");

                var searchword = Words.TakeWhile(w => w.Contains('t'));
                Show<string>(searchword, "Lay nhung tu dau tien co chua chu t:");

                var queryfilm = ListFilm.OrderBy(f => f.Price)
                .Select(x => new { x.FilmId, x.FilmName, x.Price })
                .ToList().TakeWhile(t => t.Price < 200000);

                var skipNumber = Numbers.Skip(3);
                Show<int>(skipNumber, "Bo qua 3 phan tu dau tien, lay tat ca cac phan tu con lai: ");
                
                var skipTakeNumber = Numbers.Skip(4).Take(3);
                Show<int>(skipTakeNumber, "Bo qua 4 phan tu dau tien, lay 3 phan tu ke tiep: ");
                
                var skipTakeFilm = ListFilm.Skip(3).Take(3);
                Show<Film>(skipTakeFilm, "Bo qua 3 phim dau tien, lay 3 phim ke tiep: ");
                
                var sortNumber = Numbers.OrderByDescending(x => x).SkipWhile(x => x> 5);
                Show<int>(sortNumber, "Sap xep giam dan, sau do lay cac phan tu < 5:");
}

            static void Show<T>(IEnumerable<T> data, string message)
            {
                Console.WriteLine(message);
                foreach (var item in data)
                {
                    Console.WriteLine(item);
                }
            }
        }
    },
            }
        }
    }
}
