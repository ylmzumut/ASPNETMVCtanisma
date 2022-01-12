# ASPNETMVCtanisma
### ASP.NET MVC Giriş - Notlar

##### Edit - Create
```cshtml
@* Views/Student/Edit.cshtml - Views/Student/Create.cshtml *@
@using (Html.BeginForm())
{
   @Html.AntiForgeryToken()
   <div class="form-horizontal">
       <h4>Ogrenci</h4>
       <hr />
       @Html.ValidationSummary(false, "", new { @class = "text-danger" })
       <div class="form-group">
           @Html.LabelFor(model => model.Ad, htmlAttributes: new { @class = "control-label col-md-2" })
           <div class="col-md-10">
               @Html.EditorFor(model => model.Ad, new { htmlAttributes = new { @class = "form-control" }})
               @Html.ValidationMessageFor(model => model.Ad, "", new { @class = "text-danger" })
           </div>
       </div>
   </div>
}
```
```cshtml
@Html.AntiForgeryToken()
```
##### Hata mesajları
```cshtml
@Html.ValidationSummary(false, "", new { @class = "text-danger" })
@* false olduğu zaman toplu şekilde yukarıda hata mesajlarını verir. 
   Yine de istersek value'ların altına hata mesajı verebiliriz. *@
```
![ValidationSummary-false](https://github.com/ylmzumut/ASPNETMVCtanisma/blob/master/media/ValidationSummary-false.png)

```cshtml
@Html.ValidationSummary(true, "", new { @class = "text-danger" })
@* true olduğu zaman özel mesajları ValidationMessageFor ile yazıyoruz. *@
@Html.ValidationMessageFor(model => model.Ad, "", new { @class = "text-danger" })
```
```csharp
// Mesajı aldığımız yer ise Model/Ogrenci.cs
[Required(ErrorMessage ="Öğrenci adı boş geçilemez!")]
[StringLength(maximumLength:25,MinimumLength =2,
              ErrorMessage ="Adınız 2 ile 25 karakter aralığında olmalıdır!")]
public string Ad { get; set; }
```
![ValidationSummary-true](https://github.com/ylmzumut/ASPNETMVCtanisma/blob/master/media/ValidationSummary-true.png)
