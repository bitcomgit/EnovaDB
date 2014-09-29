using Soneta.Business;
using Soneta.Examples.EnovaDB.Punktacja;

// Plik zawiera logikę biznesową obiektów definicji punktacji.
// Taki plik należy przygotować dla każdego obiektu biznesowego zdefiniowanego w pliku *.business.xml.
// Praktycznie cała logika biznesowa zostaje przeniesiona z bazowego obiektu, który jest automatycznie 
// generowany przez Soneta.Generator. 
//

//
// Atrybut określający, które obiekty biznesowe moją być dodawane do tablicy. Wykorzystywany jest 
// podczas dodawania nowego zapisu. Jeżeli dla jednej tabeli jest więcej atrybutów NewRow, to 
// po naciśnięciu klawisza INS zostanie wyświetlone menu. Brak atrybutu uniemożliwi dodawanie nowych
// zapisów przez operatora.
//

[assembly: NewRow(typeof(DefinicjaPunktu))]

//
// Wszystkie obiekty biznesowe zostały umieszczone w jednym namespace, którego nazwa została również 
// umieszczona w pliku *.business.xml (module/@namespace).
//
namespace Soneta.Examples.EnovaDB.Punktacja
{

    //
    // Nazwa klasy obiektu biznesowego brana jest z nazwy elementu table znajdującego się w *.business.xml
    // (atrybut table/@name).
    // Klasa ta musi dziedziczyć z klasy bazowej znajdującej się w wygenerowanym przez Soneta.Generator module
    // PunktacjaModule i klasy DefinicjaPunktuRow (dodano sufiks Row).
    // W klasie tej znajduje się między innymi implementacja properties biznesowych pochodzących z bazy danych.
    //
    public class DefinicjaPunktu : PunktacjaModule.DefinicjaPunktuRow
    {
    }
}
