# Internet Programcılığı MVC ile Okul İdare Sistemi
Bu proje **asp.net core web uygulaması** **(Model-Görünüm-Denetleyici)**  kullanarak oluşturulmuştur.

Database bağlantısı olarak *"select, insert, update ve delete"* işlemler için **Entity Framework ORM** kullanıldı.

**Öğrenci Sayfası:** Öğrenci ekleme, silme ve güncelleme alt sayfalarını içerir <br/>
**Personel Sayfası:** Yönetci ekleme, silme ve güncelleme alt sayfalarını içerir. <br/>
**Ders Form:** Ders ekleme, silme ve güncelleme alt sayfalarını içerir. <br/>
**Öğrenci Ders Sayfası:** Öğrenci ile Ders kaydını birleştiren genel tanımları içeren listeleme, ekleme ve silme yapısı içerir. <br/>

**Models** İş mantığının oluşturulduğu bölümdür. Doğrulama ve veri erişim işlemleri gerçekleştirilmektedir. Bağlamış olduğumuz datadan çekilen verileri hazır kod haline dönüştürülen alandır. <br/>
**Views** Projenin arayüzlerinin oluşturulduğu bölüm. HTML dosyaları yer almaktadır. <br/>
**Controller** İç süreçlerini kontrol eden bölümdür. *kaydet, güncelle ve sil* komutları yapılandırılmaktadır.

Bu kodu paket yöneticisi konsoluna yapıştırdığımızda veri modellerimiz kod tarafında modellenmiş olur. <br/>
*//// Scaffold-DbContext "Server=.\SQLEXPRESS;Database=Employee;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir data ////*  

#### Kullanılan teknolojiler: <br/>
ASP.NET Core - Entity Framework ORM <br/>
Visual Studio 2022 <br/>
Sql Server 2019 <br/>

*/Shared/_Layout* kısmında html kodları bulunur. İstenildiği üzere navbar üzerinde 4 başlık bulunur. Her başlık **mouse over** olduğunda altında giriş ve listele alt başlıkları açılır.
