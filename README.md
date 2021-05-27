# isTakipStajProject

Projenin .bak uzantılı veritabanı backup dosyası github reposunun içerisinde bulunmaktadır.

İlgili dosya projenin çalıştıralacağı bilgisayarda veritabanı yedeği eklenerek
ve  projenin DataAccess katmanında aşşağıda path'i belirtilmiş olan Context sınıfındaki
connection string kısmı düzeltilerek çalıştırılmalıdır.

--> DataAccess\Concrete\EntityFrameworkCore\Contexts\TodoContext.cs