#pragma checksum "C:\Users\albin\Desktop\MVC\Facturacion\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bcaa604b44bcb0d2b9f98e8e9065ec1da236ab6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\albin\Desktop\MVC\Facturacion\Views\_ViewImports.cshtml"
using Facturacion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\albin\Desktop\MVC\Facturacion\Views\_ViewImports.cshtml"
using Facturacion.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bcaa604b44bcb0d2b9f98e8e9065ec1da236ab6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7334f350ed5be126b4d6cfcafda2fbb13563c501", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_Layoutlog.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\albin\Desktop\MVC\Facturacion\Views\Home\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{
    Layout = "~/Views/Shared/_Layout.cshtml";
}
else
{
    Layout = "~/Views/Shared/_Layoutlog.cshtml";
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <div class=""slide2"" style=""padding-top: 45px;"">



        <ul>
            <li>

                <img src=""https://img.unocero.com/2018/11/ofertas-sitios.jpg"" />      
            </li>
            <li>

                <img src=""https://defensadeldeudor.files.wordpress.com/2015/07/oferta.jpg "" />
            </li>
            <li>

                <img src=""data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxISEhMQEhIVFhUVGBUVFRcVFhcYGBUVFRUXFxUWFRYYHSggGB0lGxUVITEhJikrLi4uFx8zODMsNygtLisBCgoKDg0OGxAQGzUmICUtLTAvLS0tLS8tLy0tLy0tLS0tMi0tLS0vLS0tLS0tLS8vLzAtLS0tLS0tLS0tLS0tLf/AABEIAJ8BPgMBIgACEQEDEQH/xAAcAAACAgMBAQAAAAAAAAAAAAAEBQAGAQMHAgj/xABFEAABAwEFBAUIBwcEAgMAAAABAAIDEQQFEiExBkFRgRMiYXGRBzIzQlJyobIUI4KSsdHwFhdDU2KUwRWi4fE1cySTwv/EABoBAQACAwEAAAAAAAAAAAAAAAAEBQECAwb/xAA+EQABBAAEAwYDBgQEBwEAAAABAAIDEQQSITEFQYETIlFhcZGhsfAUI1LB0eEVMkJyBjOCwjRDU2KS4vEk/9oADAMBAAIRAxEAPwDlIWVgLKLKiiiiIooovcbURe42omNi8xtRMbURe42IiNixG1ExsRFmNisN1bR2iC");
            WriteLiteral(@"B1nhLWBxqXhtJMxpi4fFJo2ImNiInNxXz0dYrQ3poHmr2OJJB9th1DvxXTJbLG+FjrPR0FBhiYRHHvq6Z+paN7fGq5Exisey1/vsjqedE7z2f5b2/iiK3NNQHlzS1uTZHNpBH2WaH+I7+o/wDC2SUjaZpHuiadZH52iXsYP4TewZ9y8XzejWBlos8RldIOo81c2KmWFrR5p7FU22e02uUl2JzvWLsgwdtcmhFhb70BthBs1mcI46ioBLnE5kvdvPiUj6KmRFCr1Z5IGRRQNtmAwuxSFgdSQk1IB38FXr6mbLPJKwUa51R+FeeqLKUiNZ6JFCNF2VjWjHkXAjquFQe8b1mlgmkBPYHsax7m0DwS08QDRDmJXO/b/bNDHG2NtSKuqK4CMqM4aKrmNYWUCY1rdGjzGtbo0RWjZy+muYI3mjwKZ+sBoR2p4MAOKi5s6NYkkfSmJ1OFTRUE/Aw55dE/KDyIuvTUaeXxUpuKoaj4p5tjfjXNMEZqT55GgA9UHeqM+NMXsQ72K1wmEZho8jPUnmT4rg95ebKXyMQ0jExexDvZwCkucGiyaSKKSV2SNpJ8AL+SXSMQ0jE1dEAaE58Kfr/CEnioaLmyZjzQ+vRSsRw+fDszyVvRAIJBq6dV1pft6JXIxDSNTCVqGkauqhIVenPJpUk0FB2DWg8VhwWERQlRRREUTTZ30p9w/M1K002d9KfcPzNREqCysBZRFFFFERQIiJq1RhFRNRFujaiY2rXG1FxtRFus0OJwaN5AT7/RANJPEIG5IqyN7KlXKKxAhvWo52YFKjszB7OChYrEGNwo0rfAYeB0RfONzQ35DXYqtf6Y8cDz/NZFncNQU2cFrq+ugI71qMW/nSmScHhP8pI9j80DG1ExxrcXAnCWnv3IG17GWu10fYsg3J9ZSwVOYoPFd48QHuy0q7FcMdAwyZgQOn6j4q57KWotinhZKI5H4TGXmjcvOpXIGi27T3g5wjhEodhaOlLPNe/lquf/ALsb69pv9wVn92V9e0P7kq");
            WriteLiteral(@"QqxWJsa2CJVr92l9+0P7kqfu0vv2x/clEVoESz0Sq37tL79sf3JU/drfftj+5KIrSYl5MSrH7tb79sf3JU/dpfftj+5KIrG6Ja3RpB+7O+/bH9yVP3aX37Q/uSiJy6NaXxqp3rs3b7OcMloZi9ltoc9w7w3TmmFwbGW60UcDM5vHG5jOTietyouTpmNNbnwGqnQ8Pnlb2lZWficcrfc79AUyloBqAO3JBl+I4WAuPBoP8A2Uyn8n961AayID2jMCfClPGqBvBklgJgxfXUGNzXVw1FcII30IXGWWQNzHuj3P6Kfg8FhpJRFHcrt+bIwOZO7zXkADtpa9m6yM5pGRjWhd1qe6KlZFjszuqydpdurlXnQJTYrDPaXFsbHyEAk4QXGm8nxHig3NIPAhQhiKObLfmbJ99B7Beo/g4kYYu2La3bGGtbr4ii43/3ONo28bA6OoIQdpFQHcv18fFWGKcTWcYvPjyrxblTwoRzCRgZlvHT9fHkpz5A5jZhy+Wx+vJeVw2GdFPLw+T+sUPDMO8w+h8POkqkahJGphI1CytUpUuvNL5GrUipGoZwRFhRRREUTTZ30p9w/M1K002d9KfcPzNREqCysBZRFFFFlqIt0QRcbd6Iui55JmukDXdGymNzW4iBXPCKjERrSq6RfVx3U264HstBrVxjkDavlkd57HR5UpQb+rQcyxYXOomoqNq0xtRcQRZTm4I83O7APH/pWGC9RQAYHFowg1zGtNDnqVW7ttWAEUqCjmPiJBwAHXT8lX4iFz3k1YXoMDNhewbHI4Xrv5/BGlRDMhbmWvcCe2tK7wCsxwyA5vDh2ih8Qo5Fbq5a4P1ab9NUQujbDQYbNX23E8h1R+C5rZ3PzxgDhQ1quvXJBgs8TODG17yKn8VIwo75KquMvqEN8T8keooorBeaUUUURFFFEivjamyWaoklBcPUZ1n14EDzedFq5waLJXSKKSV2WNpJ8AL+Seoe02lkbccj2saNS4ho8SqUdpbfbDhsVmwRn+NJw4gnq8");
            WriteLiteral(@"hiQto2chjInvS3F79cGI0pXQDz3D3Q1cTOSLYOp0CsW8MDHBuIfTvwN77/AEoaDqeiaW/b2LF0dkjktEm7C1wb+GI8hTtQU13XnaxjtM7bLD6zGHCcJpXFQ8PadySi1+UCCzgx2CzNYKec5oFdRXC01Pe48kbsHtDJbW2my2iTE6Rji0mgycMLmgZAaggDgVHEgkflLrvkNB77lWzsFJhYDPHCGBtavp8lXqQKytr0Qj7xumw+iYbVKPWdRzQexxGHdqAe9Ir18oFsmc0tf0bQQQ2MEA0NRiJzOQ00PBVi1xFj3tdkQXA94NCvPRnDip1akV7QAafEKGZ3kUNB4DReli4Vh2nPJ9478Tzm9hsOgX0Js3e7bXZ2TtoCcnj2Xjzh/kdhC495RbK6O3zV9ch7TxDgD+JI5Iryb7RfRp+iefqpaA10afVd8aHsPYrp5TNm3WmMTxNrJECHAauj1y4lpqadp7FLe4zwWNxuvPYaNvCeJlrtI3ggHrfwOnoQSqJ5O7+ZZLTWQ0ZICxx4Zgg8iKd1U3tlwWaa1SzCRr2Pe52FjhvzPHImugVAcwjUELLZXDQlRY5gG5XNsbq+xfC3ySmaCUxuIokAGx+R8wbpXO8rCR9XFFhByoBme8nMr3Y9g5HgGSQNcdGgYqd5Vcu7aK0wuDmyE03O6ze6jqjwXULgv8WyDGyjZGZStGdDuc3sND3UIzpU6Y3FzFlQd0VroCenIDovLYvhGIwjhM92fUd6zYN6E357Gzr0XMDs9LIJXMAL4jhkj9bKoqOOYpRVuVq6xaf/AI14MmJGC1DA4jQPqBUjvwO+0qZ5QLA2K1uwigeA+nAmoPxFea6cOx75JOyfzbbT6aFp9OXtqonFoG9p9oZs/vdT/MOhBVOlCFkCOlCElCulTrQoooiKJps76U+4fmalaabO+lPuH5moiVBZWAsoii9RheVsiREysVtkY17GPIa8AOAOtDVbmSOLWsJOFpJA3AupUjvoPBBRBGRIiJiCLiCHiCLiCIiYgi");
            WriteLiteral(@"4gh4gi4giIiJqrN4TOF4xNDnAF8AIBIBBc0EEb1aogqlev/k4f/ZZ/mam6A0bC+hX7N2UkO6ECmeRIHgDROAFlRahoGwWz5XvrMSa8Sookd8bT2WzVEkoxD1GdZ/MDTnRV87S2+19WxWYsYf40o3e0K9XkMS0dMxprc+A1UuDh08rc9ZWficcrfc79LV0tFpZG3G97WNGpcQ0eJVUt+3sQd0VljfaJNAGtIb40qd2gp2oZuxgIM95Wp0uEVcMREbRvGJ2dO7DqgbZt3YrI0xWKEE8aYWntJ89/OneuMkr/AOohvxKn4XAQPNRNdMfLuRj1J1PwvkjRdl623OeYWaM/w464iO2hr4u5Jtc2x1igzDOlcPWlo8g92g8KrlV87aWy01BkLW+xHVoz3Za8yUls1uljcJGSODhmCHEHxCifaIwby2fEn8tQr48GxkkWUytjH4WNodTYJ87tdO8pO0Nssz2xxEMje2oe0HGTo5uLdSgOQGoXLrRaHyOL3uc4nM1JNe8nVdXu0x31ZGMldhlheMbgBUggioHq4h8WrXtVsNZ4rE8wM+sj+sLnElzmgEPB3DI4qADzVtNE+W5AbbuP0WnDsdhsEG4WRmWW8rqGm+jifA2PmuTsFSAu1bI7GWez4LS2R0ji0Oa7zW0e3UNHEHeVxU5Ls/ktvfprL0Tj14Th7Sw5t8DiHgtMHkMlOHopX+Ju3bhQ6NxDbpwHMHTXnV6VztULyk3f0VukNKCSkg+3m7/cHLVsfZRaGz2OoxSM6SIHfLFUtH3HSDmrd5Y7vq2C0DcTE7n1m/8A7VA2ZvD6PaoZtzXtLvdJo4eBK0kAjmIO1/A/su2CkdiuGNLD3g3T+5m19QPUJc5pa4ilCMqHUHgV2nydbQfSrOI3n6yIBprqWDJru07j/wAqmeVS5BFOLQymGarnAUykHnGnB2vfVVzZe+XWS0MmbpWj2+0w+cDy07QFtG52Hlo9fTx/NaYyGPi+AD4/5qtvkebT8Qffku3Xps/Y5aunhj9pzy");
            WriteLiteral(@"MB73PaQfErmk1w2CWc2eGQ4jiw4SHNo3Sh35cCmflTL5IoLVFI4wPAq2pwg5ua6mgJaSPsrnl22x0MjJW6tc0jtodOei6zytD8pYPXmR4ilW8I4fiH4XtWTuBogNGzXCxTgb2I2oIi/rofZZDG7Pe1w0cDoR8RyTPYG8jFa2N0ZL9U77ZAB5OwnuBW3ba/ILSIuixVAOIkAUr6vbQgpLcdnc6ZmHQOxE8KGqiyMb2mVmo5K7ie+fh94sZTlOaxtVi66Zl1DbO7Q6zPA8+M9K3j1R1h92vgFyvaK8nWiVr3atYxveWjM8zVPdq7+mmc5hfRlfNbkD38VWLVm0O5H9frVdMFgnYaQOko3YFcro9br914psv2nBPj5x98f27PHoNHJXKEJKEbKEJKFcqnQjlhenryiKJps76U+4fmalaabO+lPuH5moiVBZWAsoii2xLUt0SIi4gi4kLEi4kRFxBGRISJGRIsIuJFxBCxLeLQ1upr2b1hzg0WV0jifK7JG0k+AFn4I+IKo3uaXlFXQPs5J4AOaST2Kwi0PfkxtBxP6p+K1tumd07Q4dTEzpJK5YajEK7qCuea4dsXfyC/M6D479FYfw4Rf8S8NP4R3n9Q002+Rcei6beO3sId0VljktEmgDAcNc650JO7QUPFBi7b1tuc8ossZ9SOuIgjeAa8nO5L3a9sLusLTHZ2Nc7SkQABI0xyHzu8Ykv2Y28farUIZg1scjSxob1aOPm1JNTWhb3uXAva5wa993yGg6qyZhpY4nS4bD5QATmkovNa21uw9uqYOsF03aKzFskg3SUkfWlRSMdVumRIHekd9+VB7qssrAwaB76Od3geaP8AcqZtLdzrPaZoHEnC52Eu1LSagnvaQea0XPYxNNHC5wYJHNbiIqG4jQZd9FFdO8dxgy+Q/VX0PCcMWjEYh5lNXbtq30b4Vy18gun+Tm+jbYZ7LaHl7jidmSSY5AGuA7ATyxLmV+Xe6zzyQO1Y4ivEA5HupTxXatm9jbPYzjYXOkoRic");
            WriteLiteral(@"aZHUADdlvqqj5Xrno6O1tGTvq5O8Alp5jL7IXeaF3Ygu3HyVdwviGH/iT2QaMk2sV3gOQ8CL870rZVzyeSQ/S2xzxse2WrBjAIa40wnPiRh+0tO3VyCyWpzGikbqPZ7rq5cqEcgkMUhaQ4GhBBBG4jMEJttNtFJbntfI0DC3CA0aDMk9pJUTO0x0d70/NegdBK3GiVh7haQ4XzB7pA8eXonPkqtxZbmxjSRr2u5Nxg+LR4ldoljDgWkVBBBHEHULhex+0MFjfjfZy+TQOx5NadcLMOtN5Phmuz3LekdqibPESWurkci0jVrhxCsMC8Zct67ryX+J4ZPtAmyENoC9NTr56aeNXS4RtTdZs1qlh3Bxwni12bT4Ec6pl5O73+j2xlTRkn1buFHEUPJ2HlVW3yvXPiZHamjNv1b/dNS08jiH2guVsdQg8FBkb2MunLUL02CkbxLh9P5gtd67H9V3rby7+msUzRqwdI3vj6x/24hzXBDke5d+2SvIWuxxvdmcPRSD+oChr3gg/aXDb5sfQzywnVj3N76OIrzou+MAdleOYVb/hl7ou2wsm7XX+R+Q914BltDwOvI80A1cTwA1JyWh7SCQQQRkQciCNQQrx5IreGWp0RpSVhp7zKOHwDvgmu2ewks9r6SAAMkGJ7iQ1rX6OJ355HIHMlcGwF0eduutUrKTiscGLOHmAa3LYcTofLy516eaB8n15R2iN912g1a8ExE6g6kNJ316w7QeKrdv2beyZ8Mb2vwuc3UAnCd4OniV0bZ7ydwwOZLI9z5GkOGHqtaRQj+o0I4juXLbbaZBeVokFcAmmzFM+s4CiliAGMdtpW2vL5Lz0nFJG4t38NGYO1cMpIzbZhRBFirOgJ11tH2fZZ+sr2MG/MF3IDLxoipp44WGKId7jTEfyHYgZrZI/sHE1B+CGew7ySVtExrdYm35nbp+w6rljcTNMMuOmDR/046J66kA8xmcR5LRLVxz0QkrxSjc6/8H/C3yBCSruInOIMjr51sP3VW7HRxs");
            WriteLiteral(@"LMNHlsEFxOZ5B310Db5gD0KDlQcqMlQkq7quQci8r3IvCIommzvpT7h+ZqVpps76U+4fmaiJUFlYCyiKLdEtK2xIiMiRkSDiKNhREXEi2VGVM1pLsJoBTn4a8M01uayY3Z6DMngBqSozXSSi200e5/QK2lgwmDeWS5pHjQgdxvpf8AMfKgAeqzY7vllNGindUH4prFc8TD9ZKyvB72k/jklN634TWKEljBVuWTndrjrRKHNdQOOKhrQ0yNNaHeoT52A90Zj4u19hsvS4bhOJljAleI2n/lxjL/AORuyTz1KvxuhzWCUSRlpIya4OJ7erUDmk+3tmkhmDA9xic1rmAnLTPLTWp7qJPct7yWaQPbQtyxMObXNrm1w39+oV+2uijtdi6WMElg6SMjXoiOsw9rR8iw53asJO62jgPD8TG2h2ZsWBVXVX53zvUEnkuYDMrpmyvk6IMdolmI82RgiNTmA5pxnJvIHvXMtF0/ZLbyCCxiOcuMkZLWtbmXM1BJJDRSpGugGq0w/Z5vvNlN44caIR9k3ujQs0frVevK/dFWx2to0PRv8CWk/wC4V91cwY7CQRuXZ7ovtl72e1QFoYaUArWgI6jq0FSHD8Fxu1QOY9zHChaSCOBBoR4rbFAF2duzvorjwCSRkTsJMKfGdvI6j8xp5Loc/lQcImNjiBlwgPc89XEBQlrRrXXM8lZbDM29LsIdQyFpad1JmCrT2V6p+0QuT7NXL9MmbAJGsJqaurnQVIAGppU0y0XaNl9mWWJhax73YsJeXUDatBza0aa8TuXfDOlkPe1bVclT8ZhwOCYGwd2UODhuefM+F7eYGi4JKwhxFKEGhB3EblcfJtd9ktD5bPPGHOLaxGpBbTzg0A0rQgjL1SseVC6OgtZlaOrMMfZir9YPHP7Srlw3g6z2iKdurCDTiK5g94qOaiAdlJ3hdbr0kjjjsDmhNFzbFGqO9X6iisX3drrNPJA7VhIrxbuI7CKHmrt5Ir5wyPsjjk8Yme+0Zgd7flC2eVa7mv");
            WriteLiteral(@"bDb482vDWkjfUYo3cxlyCoN12t0M0crDQsc0jvaa0PZuWx+4l9Pko7a4pw6nbuFHye3/2HsvoW9rvbPDJA7SRpb3H1XcjQ8l8726yuikfG4UcxzgRwcDQjxC+jLvtjZo45m+a9ocOyorQ9o0VYvTYOz2i1OtMjnUcASxlBV1KElxrkQBkAN+anYmAy0WfQXl+B8UZgXSRz2G7+jhpXX8gqr5Ir2LJn2Zx6soxN99v5ivgE52l2Bda7Y6fpGsjcGFxpV2IANIDch6oNSd6bS31dt3twR4MQyLYQHvNNznV195yWvv28rVU2aFtni/nTZHDnmC4UNf6WnvWgDGs7N5zUbofXzUl8uJlxTsZh29k1wrM+qPmBzOg0AdqE0sGzt33cOldha4aSTOFa69QaV7hVAW/ygMLujscL5n6YqEN76DrEd9Emh2cbI/FaZ5J3ZVLiQD2AE4qcx3J/DEyNuCJjWN4MAFe+iiSY/KMsYr6+vH1XB8cGfNM50zvO2tH+46+FBCMuW8bcMVqtAhiP8KLUje0gZeJcuRvc5t4yQVJZHJKxtaZhmIAmmpyXe7otuE4TofgeK4Haf/LWj/3z/M5TMGY5WZ9zzvVV+MxmI/yrys5Nb3R1rfrafyIOVFyoOVTlWoSVByouVCSosISVByouVByosoWReF6kXlEUTTZ30p9w/M1K002d9KfcPzNREqCysBZRFFsiWteoyiI2IoyIoGIouIoiaMNWjiPz/XgVYLo9DLh16N3h/wBVVbsjs6cf1+Y5p7s5OGvwHzXZEcQcj8FHYKLouo9D+hVviJMzIMbVkENd5uZRF+bm0kR1XRrnYy2XW6Gn1kVcJHtirm5doLm+Kod62UxSvj4E8xu8cjzT3YC8uitHRk0EnVPvatPjlzVZCafldz0K9txS5cL28OpZT2+da/EXpzVYc2hortsPeBe0WdxqGuBpxYSA9vdUg/aKU7bXZ0NpdQdWTrj7Wo5GvwQGz1v6C0RSnQObi7RWhHhVZjd2MuvLQrXGxt");
            WriteLiteral(@"4nw+4/6m5m+u9f7T6rbtVdf0a1Swbg44e1pzafAjnVLIYy5wa3MuIAGlSTQZldF8qTIpmstMRqW9V+RFWmpY6vfUcwucMdQg8FrPH2by36pduFYv7XhGyf1bH+4aH336rrewexdoscnTySAVaQWNOInFTJx0FCAcq6Kt+Va5+itInaOpMMR/8AYKB/jkftFXK6dubO2yxSTvcHgYH0aXddooSaDfk77SVbVbQWG8bM+KGQmRtZGVY4VLR1hmN7ajvop74WmDuev10XkMNxOePimfE1d5HUKFX+R1s2a5rmt1W50EsczdWOa4duE1oew6c12O8vKDY4mBwcZHOaHBjNRiFaOJyBG8ajguIuFDRb7LY5JDha0nkTTv4KDDO+MEN5r1nEuFYfFubJMay35WPM+C6lfkovS7HWhrA2SFznFta4aDrCtN7CHaatXKGxkmlFftjLxhu8SC0ztwSAAxtDnkOGhNBhGRIyru4Jxde0dz2YEwsJcPW6Ml5P9Ln0pyICkyQl4D3nLprfkqPB8TZhJJcNhmmUZrZl1AB3BOugOx1vXVFbMXbLabsdZLTG5mREZeCMj1mOzzyd8KL3Ydi7vsbWy2hzXEb5iAyuvVZv7jVVu+fKhI44ISyBpyxuq9/fkCB4c0LYr0upx6S2Wye0P4FsuHu9o+IHYuoaHVlbdaWdB+/soEs0kTpBNN2Yc7MY4+86zvrdNvzd0VvtG3EfobBZ3zOGQwsLWAcQAKkcgO1av9CvK252ucQRH+FFqRvBANPEuWLH5Q7oiGGJ2BvBkLwOdBmiv3o3Z/Of/wDU/wDJdexc7/MdfkNAq/7fHCf/AM0YB/E7vO9dRlB9B1RdjuCxWMAti6STc5/XfXjnk3kAtFvmkkd1zQDQDQf8r3/q0VoAmgNWPFQ78cty8MZiIFQK7zx3DsVPip3OcYmaC6oLqwuf97KSXHmbJ6eC8NaBotvRdQPrvIPZvFOSxJC4GhaQe5bpm4Iww+c52Km8NAIFe+qisZeYuGwPQ8vrwt");
            WriteLiteral(@"budtR3QwVB2s2YwWpluiHUeT0wHqvIPX7j+Per8sOaCC1wqCKEcQtsNOYXh3LmsTRCRtLmMpQkpTnaC7TBIW+qc2HiOHeEjlK9Mxwc0OGxVMQQaKGlKElKIlKElK2WqGlQkpTGCxvlJDGk4QXOoCaNGpNFfo9i7AbodObYzFix9PQ4WuAp0OHzt+mtdyIuSvWF6lABIBqNxFc+3PNeUWVE02d9KfcPzNStNNnfSn3D8zURKgsrAWURRZasKIiKiKLiKAiKLiKIj4imkMtHNfx1/X60SeNyPsxqC3mP1+tVwm7pEnhv6HQ+26s+HffNkwv4xbf726j3Fg9An+0cWOOO0AaDo38qlp5jL7Kr8TyHNINKGoPAjRWS5JBLG6Bx88UHY7Vp8QFXJoy1xaRQgkEcCNQoGNjyvzePz5r1n+GcYJsL2R3Zp/pP8vtqOi6NtFZvpt3ttbRV0eZpwpSQcjQ9y5tor35N7/ijZLZLS4NikBcC7TMYXtPe38O1UeemI4TUVNDSlRXI03LhK/Ocx3UzhMT8M6XDEd1ptp5ZXa0PQrqWzMLLbd4a7J7AYS6nBoLC7jSrfurmFrgcx7mOFC0kEcCDQrpvkygcyyyPOQfIMPaGDMjm4jkqhtF0Mtqlf0gaMZDuJoaEgclqzNK7I3Uivj+6qsPj4MDjZ2PdTCSb5ZtLAHnZH+kBA3RMHMkgdvGJvYRT8c/glNitZglqNxTaaeICkLSf63EE8hpuSOVkYNZHYj7Of4D/AIVnA/sm5CbPgNf2VTxPDHHTHExNyMIFuk7jSfEXrRFbDdOoZ7NUvLMZJLg2owg65gCp8QvVqvaQinVjZwaAAe8hIJLwOjBh8D8EG5xPnHEssif/AEgM+Lv0C5YnGQOP3z3TkeNsj9h3iR4gDNzTCW3tBq0F54n9f4CFntT3au8FoUXVsDAbOp8TqoM3EsRI3swcjPwsGUfDU35kqAKKKLsoGyiiiiIrXsFtF9Hk6GQ/VSHf6jzoe4711hfPi6f5Pdo+mZ9GlP");
            WriteLiteral(@"1jB1CfXYN3ePwVRxLC3963r+v5FWGDnr7t3T9Fd2Wl4FGveBwBWvtJJJ1JzJUUVQXuIok16qwAA2UUWueZrGl73BrRmSTQAKkXltsZXmKzCjBXFIdSP6Ru711gw75jTR15LnJM2MW5F7bzMJYA8lzagt1AB39hVOlct0z61JQkrl6SCLsowy7r6+vmqiR+dxdS0ylCSlb5XISRy6rRb7Fe00GPonluIFp57x2jils1tk6MxYzgL+kIrkXgUxHtoVJHISQosUF4UUURZUTTZ30p9w/M1K002d9KfcPzNREqCysBZRFFFFERe4yionIIIiNyImEbkZZ5KEFLY3IqNyw4BwIPNbxyOieJGbggj1GqdWWcxyV45/n/AJTa8LALRSWKgflibkKnMktGneFXmuq3Fw/Pdyp4FFWW0ubm05KJTHRZZDtp7ftSuy+eDHdtgwT2gzAAE6O1INeDr9NNQtguO01p0Mlfdd+NE7ubZZmUlrnjiYNW4243dmeQ+J7Eu/1aUimLLtr+vwWoguNXuJ7yopwoePu79TQH7q4n4xO0ZZ3NjPNre/J88repPRXO9trYgz6PZGZAYWkAhrRp1a5k9pCplkubOpyr2lx+J/JFw0GVByRLHrvh8A2IGyTe/n6+nsvPO4kxhvDRgEf1O7z/AFFjKCedAnzXh1yxOFHY/vU/BeWbK2bg77xRrJFubIprWtaKaKVdLNJM7PI4uPiTfzQDdlLLwf8AfK9jZKycH/fKYtkWxsi2XJK3bI2Snmv++Vq/ZWzey77xTzHVYREk/ZWzey77xU/ZWzey77xTtRESYbJ2Wnmv++V5Oytl4P8AvlOXuotTpERJ3bL2bg77xUs1yQxPbJHjDmmoOI5EJk960Penksq6XfbBKwOGuhHArFvt8cLcTz3Dee4KnWS8XxEuYdRTPRA2q0ueS5xJJ3lVP8LHamz3fj6fv8FO+2nJt3l62gtRtR+sJDBowGje88SlbImsFGigW6R6GkerRjGsblaKChOcXGyt1jsck8");
            WriteLiteral(@"jYomFznGgAGnaTuHave09yS2OZ0UjTh1Y+nVeOIP8AhFxbQfR+hfZcTJG+f1uq7PzXj1q/CqF2v2pmtsrnFxEQ8yOvVaOJG89q3IWoNqvSuQkrltkchZXLCytMjkO4r3I5a0RRRRREUTTZ30p9w/M1K002d9KfcPzNREqCysBZRFFFFERRbbMxznBjQS5xAAGpJNAF5hiLnBg1cQB3ldN2Huyz3feEDLXEXyS+glDqsZJTMGOla1qA7NKWLGy52w7kVG9M9ubdY5bXKbHE6MYyHEnqvfWhc1lOoK138gksbkWUzgloiRKTqlkbkTG9czEwuzVqpIxmIbF2IeQ3wB0/+eWyYRuRMb0uY9ERvXRRapMWPW9j0uY9EMeiymDJFubIl7ZFtbIiJg2RexIkt43l0LQ6lSTQDRLBtO7+WPvH8kWFdoDlVbFTmbZOAA6EfeP5L1+2bv5LfvH8kRW9RVD9s3fyW/eP5Kftm7+S37x/JEVqtGleCCdIkD9snEEdCM/6j+SEO0rv5Y+8fyRFZXSLS+RL7BeHStJpQg01qtz5EWV7e9DvesPeh3vRFl70PI9R70O96IvMj0NI5epHIaRyIvMjkLI5e5HIaRyIvLisKKIiiiiiIommzvpT7h+ZqVpps76U+4fmaiL/2Q== "" />
            </li>
            <li>

                <img src="" https://www.muycomputer.com/wp-content/uploads/2020/11/Ofertas.jpg"" />
            </li>
            <li>

                <img src=""https://i.pinimg.com/736x/60/a9/99/60a9993e6596d1810818eefa84a0a8c5.jpg "" />
            </li>
            <li>

                <img src="" https://image.freepik.co");
            WriteLiteral("m/psd-gratis/etiqueta-mes-ofertas-brasil-3d-render_363450-839.jpg\" />\n            </li>\n        </ul>\n\n\n\n    </div>\n</div>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
