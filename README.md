# Acunmedya Odev-Mayıs

**AutoMapper**
Farklı sınıflar arasında veri taşımak için kullanılır.
Her sınıf için ayrı Profile dosyası oluştur.
Serviste IMapper kullanılarak map işlemi yapılır.

**Global Exception Handling**
Tüm hataları merkezi olarak yakalayıp yönetir.
Middleware sınıfı içinde try-catch ile hata yakalanır.

**CQRS**
Okuma ve yazma işlemleri ayrılır.
Performans artar.

**Clean Architecture**
Katmanlı yapı: Domain → Application → Infrastructure.
Bağımlılıklar dıştan içe olur.
Kolay test edilir.

