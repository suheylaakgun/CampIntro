// See https://aka.ms/new-console-template for more information
int sayi1 = 10;
int sayi2 = 30;

//değer tipte yalnızca değer gönderilir ve ramde stackte tutulur.
sayi1 = sayi2;
sayi2 = 65;

//referans tipte adres ramde heap alanında tutulur
int[] sayilar1 = new int[] { 10, 20, 30 };
int[] sayilar2 = new int[] { 100, 200, 300 };
sayilar1 = sayilar2;
sayilar1[0] = 999;