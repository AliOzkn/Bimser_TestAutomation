# Bimser_TestAutomation

<h4>Kullanılan Teknolojiler:</h4> Visual Studio 2022, C#, Selenium, NUnit, Allure Report

<h4>Dizayn</h4>
Yapı, site üzerindeki fonksiyonların gerçekleştirildiği kısım ve test işlemlerinin gerçekleştirildiği kısım olmak üzere 2 bölümden oluşmaktadır.<br>
<br>

<p align="center">
 <img src="https://user-images.githubusercontent.com/107454207/214777260-7da009da-4a39-4039-befa-b91ea038034d.png"/>
</p>

  - <b>Home</b> ana sayfa üzerindeki işlemleri yaptığımız metotlar için;
  - <b>Login</b> kullanıcı girişi  metotları için;
  - <b>Product</b> ürün seçimiyle ilgili metotlar için;
  - <b>Cart</b> ürün doğrulama ve kullanıcı çıkışı metotları içindir.
  - <b>BasePage</b> PageFactory sınıfını ve web driver'ı başlattığım sınıftır. Bu, PageObjects sınıflarına extend edilerek kullanılmaktadır.
  - <b>TrendyolTest</b> sınıfında, testler bulunmaktadır.
  - <b>BaseTest</b> sınıfında, testten önce driver çalıştırma ve testten sonra tarayıcıyı kapatma metotları bulunmaktadır.
 
 - Kullanılan dependencies ler aşağıdaki gibidir.
 
 <p align="center">
 <img src="https://user-images.githubusercontent.com/107454207/214777589-cc047876-c773-4560-acbb-96d39db2ba01.png"/>
</p>

- Raporlama için Allure Report kullanılmıştır. Rapor dosyaları ***allure-results*** klasörü içindedir. Terminale ***allure serve {allure-result klasör path'i}*** yazılarak görüntülenebilir.

 <p align="center">
 <img src="https://user-images.githubusercontent.com/107454207/214778085-a3cfe3d8-3748-4d83-89ae-82d91144a2fe.png"/>
</p>
<br>
 <p align="center">
 <img src="https://user-images.githubusercontent.com/107454207/214778089-ebe30919-1a7a-4a9b-b691-10917412b9b9.png"/>
</p>
