# MuhtarlikOtomasyonu

İşlemler

1. MuhtarlikOtomasyonu.UI 

appsettings.json da yer alan IdentityConnectionString değerini kendi connectionstringin ile değiştirmelisin


PackageManagerConsole Da
clear
add-migration "AddIdentityTables" -context MuhtarlikOtomasyonuContext
update-database -context MuhtarlikOtomasyonuContext

add-migration "KisileriEkle" -context MuhtarlikOtomasyonuContext
update-database -context MuhtarlikOtomasyonuContext

add-migration "TablolariEkle" -context MuhtarlikOtomasyonuContext
update-database -context MuhtarlikOtomasyonuContext


Yeni Model Eklemek İçin ;

1 - DBModel'e Ekle
2 - Contracts'a Ekle
3 - Implementations'a Ekle
4 - UnitOfWork'e ve IUnitOfWork'e Ekle
5 - MuhtarlikOtomasyonu.Common'da VModelse Ekle
6 - MuhtarlikOtomasyonu.Common'da Maps'a Ekle
7 - MuhtarlikOtomasyonu.BusinessEngine de Contracts'a Ekle
8 - MuhtarlikOtomasyonu.BusinessEngine de Implementation'a Ekle
9 - MuhtarlikOtomasyonu.UI'da Startup'a Ekle
10 - MuhtarlikOtomasyonu.UI'da Controllers'a Ekle

