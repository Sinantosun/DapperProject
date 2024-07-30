Dapper ORM kullanarak restorant projesi geliştirdik.
Ayrıca Omer Colakoglu hocamızın kaggle de yayınlanan MSSQL için 10 milyon veri seti olan 10Million Rows Turkish Market Sales Dataset(MSSQL) veri setini hem dapper orm hem entity framework orm kullanarak projeye dahil ettim.

Dapper nedir ? 

Dapper, .NET dünyası ORM Aracıdır. Veritabanı işlemleri için herhangi bir .NET projesine eklenebilen bir NuGet kitaplığıdır. ORM (Object Relational Mapping), Nesne İlişkisel Eşleme anlamına gelir.

Neden Dapper Kullanmalıyız?
Oldukça hafif ve yüksek performanslıdır.
Veritabanı erişim kodunu büyük ölçüde azaltır.
Herhangi bir veritabanı ile çalışabilir. SQL Server, Oracle, SQLite, MySQL, PoestgreSQL vb.

Dapper’ı Ne Zaman Kullanmalısınız?
Dapper’ı kullanıp kullanmamaya karar verirken, birincil neden olarak performans akılda tutulmalıdır
Bu nedenle Dapper, verilerin sık sık değiştiği ve istendiği senaryolarda iyi bir seçimdir. 

<h1>Admin Dashboard Alanı</h1>

![image01](https://github.com/user-attachments/assets/2587996b-3027-4496-b77e-953f35e8fa61)

menüler içinde en pahalı yemeğin adı ve fiyatını, en uygun yemek fiyatını yemeklerin ortalama fiyatını, son yapılan 5 rezervasyonu ve bütün işlemler isteklerin ajax ile yapıldığı Yapılcaklar listesini görüntülemektedir.

<h1>Admin Ürünler Alanı</h1>

![image02](https://github.com/user-attachments/assets/dc3df375-5f07-43aa-beb0-eaf6b5b468b0)

Ürün listesi burada yer almakta ve ilgili crud işlemleri burdan sağlanmaktadır.

![image02](https://github.com/user-attachments/assets/821e1099-8c06-41f7-a11a-1f5e42057113)

Dapper kullanılarak 10 milyon MSSQL veri setinin listelendiği alan
