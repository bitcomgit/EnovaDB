using Soneta.Business;
using Soneta.Examples.EnovaDB.Punktacja;
using Soneta.Handel;

//
// Plik zawiera logikę biznesową obiektów punktów.
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
[assembly: NewRow(typeof(Punkt))]

//
// Wszystkie obiekty biznesowe zostały umieszczone w jednym namespace, którego nazwa została również 
// umieszczona w pliku *.business.xml (module/@namespace).
//
namespace Soneta.Examples.EnovaDB.Punktacja
{

    //
    // Nazwa klasy obiektu biznesowego brana jest z nazwy elementu table znajdującego się w 
    // *.business.xml (atrybut table/@name).
    // Klasa ta musi dziedziczyć z klasy bazowej znajdującej się w wygenerowanym przez Soneta.Generator module
    // PunktacjaModule i klasy PunktRow (dodano sufiks Row).
    // W klasie tej znajduje się między innymi implementacja properties biznesowych pochodzących z bazy danych.
    //
    public class Punkt : PunktacjaModule.PunktRow
    {

        //
        // Ponieważ pole dokument określono jako readonly i jest ono inicjowane tylko podczas tworzenia nowego
        // obiektu biznesowego, wartość inicjującą należy przekazać jako parametry konstruktora. Dlatego 
        // należy zdefiniować potrzebne konstruktory.
        // Ten konstruktor wykorzystywany jest przez bibliotekę do tworzenia obiektów biznesowych odczytanych 
        // z bazy danych. Nie będzie wykorzystywany przez programistę.
        // Należy wywołać konstruktor bazowy.
        //
        public Punkt(RowCreator creator)
            : base(creator)
        {
        }

        //
        // Konstruktor inicjujący nowo utworzony obiekt biznesowy, które będzie dodany do bazy danych.
        // Parametrami konstruktora są pola zaznaczone jako readonly. Ustawienie wartości tych pól 
        // później nie będzie już możliwe.
        // Należy wywołać konstruktor bazowy.
        //
        public Punkt(DokumentHandlowy dokument)
            : base(dokument)
        {
        }
    }
}
