namespace ex13_linqs
{
    class profile
    {
        private int age;
        public string Name { get; set; } // 자동프로퍼티
        public int Height { get; set; } // 키에 -21억 부터 21억까지 수가 들어감
        public int Age { get => age; set { if (value >= 0 && value < 200) { age = value; } else { age = 20; } } }

        class Product
        {
            public string Title { get; set; }

            public string Star { get; set; }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("LINQ 테스트");
                profile[] arrProfiles =
                {
                    new profile { Name = "정우성", Height = 186, age = 49 },
                    new profile { Name = "이정재", Height = 186, age = 46 },
                    new profile { Name = "김태희", Height = 168, age = 28 },
                    new profile { Name = "전지현", Height = 158, age = 28 },
                    new profile { Name = "이문세", Height = 173, age = 56 },
                    new profile { Name = "장원영", Height = 165, age = 13 }
                };

                Product[] arrProducts =
                {
                    new Product { Title = "비트", Star = "정우성"},
                    new Product { Title = "오징어게임", Star = "이정재"},
                    new Product { Title = "엽기적인 그녀", Star = "전지현"},
                    new Product { Title = "도둑들", Star = "이문세"},
                    new Product { Title = "DYNAMITE", Star = "RM"}
                };

                // LINQ 미사용
                List<profile> profiles = new List<profile>();
                foreach (profile profile in arrProfiles)
                {
                    if (profile.Height < 175)
                        profiles.Add(profile);
                }

                profiles.Sort(
                    (profile1, profile2) =>
                    {
                        return profile1.Height - profile2.Height;
                    });

                foreach (var profile in profiles)
                {
                    Console.WriteLine($"{profile.Name}({profile.age}세), {profile.Height}cm");
                }

                // LINQ 사용하면
                var profiles2 = from profile in arrProfiles
                                where profile.Height <175
                                orderby profile.Height
                                select profile;
                foreach (var profile in profiles2)
                {
                    Console.WriteLine($"{profile.Name}");
                }

                // LINQ 기본
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                var result = from n in numbers
                             where n % 2 == 0
                             orderby n descending
                             select n;

                Console.WriteLine(result.ToString());

                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }

                // group by
                var groupProfiles = from p in arrProfiles
                                    orderby p.Height
                                    group p by p.Height < 175 into g
                                    select new { GroupKey = g.Key, profiles = g };
                foreach (var group in groupProfiles)
                {
                    Console.WriteLine($"-175cm 미만? : {group.GroupKey}");
                    foreach (var profile in group.profiles)
                    {
                        Console.WriteLine($"{profile.Name}({profile.age}세), {profile.Height}cm");

                    }
                }

                // LINQ JOIN
                var innerJoinResult = from pf in arrProfiles
                                      join pr in arrProducts
                                      on pf.Name equals pr.Star
                                      select new
                                      {   Name = pf.Name,
                                          Work = pr.Title,
                                          Height = pf.Height,
                                          Age = pf.Age,

                                      };
                Console.WriteLine("내부조인 결과");
                foreach(var item in innerJoinResult)
                {
                    Console.WriteLine($"작품: {item.Work} / 이름 : {item.Name}");
                }

                var outerJoinResult = from pf in arrProfiles
                                      join pr in arrProducts
                                      on pf.Name equals pr.Star into ps
                                      from pr in ps.DefaultIfEmpty(new Product() { Title = "작품없음" })
                                      select new
                                      {
                                          Name = pf.Name,
                                          Work = pr.Title,
                                          Height = pf.Height,
                                          Age = pf.Age,

                                      };
                Console.WriteLine("외부조인 결과");
                foreach (var item in innerJoinResult)
                {
                    Console.WriteLine($"작품: {item.Work} / 이름 : {item.Name}");
                }

            }
        }
    }
}
