ASP.NET Core 8.0 

Projenin Teknik Mimarisinde Neler Var?

Mimari: N-Tier Architecture (Çok Katmanlı Mimari) ile temiz ve sürdürülebilir bir yapı.

Backend: ASP.NET Core 8.0 Web API üzerine kurulu, MVC ile consume edilen bir sistem.

Veri Yönetimi: EF Core (Code First), Migrations ve performans odaklı Lazy Loading Proxies.

Güvenlik: Identity kütüphanesi ile JWT-Token tabanlı ve Role-Based (Admin, Teacher, Student) yetkilendirme.

Best Practices: Repository Design Pattern, AutoMapper (Entity-DTO), FluentValidation ve Named HttpClient kullanımı.

Bu projede beni en çok heyecanlandıran kısım; Admin, Eğitmen ve Öğrenci olmak üzere 3 farklı panelin birbiriyle entegre ve yetki bazlı sorunsuz çalışması oldu. Henüz production aşamasındadır. 
