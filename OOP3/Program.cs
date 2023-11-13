// See https://aka.ms/new-console-template for more information

using OOP3;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
//ihtiyacKrediManager.Hesapla();
IKrediManager tasitKrediManager = new TasitKrediManager();
//tasitKrediManager.Hesapla();
IKrediManager konutKrediManager = new KonutKrediManager();
//konutKrediManager.Hesapla();

ILoggerService databaseLogger = new DatabaseLoggerService();
ILoggerService fileLogger = new FileLoggerService();

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(konutKrediManager, databaseLogger);
//basvuruManager.BasvuruYap(tasitKrediManager);
//List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };
//basvuruManager.KrediOnBilgilendirmesiYap(krediler);