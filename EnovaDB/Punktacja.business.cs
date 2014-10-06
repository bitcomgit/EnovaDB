
//----------------------------------------------------------------------------------
// <autogenerated>
//		This code was generated by a tool.
//		Changes to this file may cause incorrect behaviour and will be lost 
//		if the code is regenerated.
// </autogenerated>
//----------------------------------------------------------------------------------

using System;
using System.Text;
using System.Collections;
using System.ComponentModel;
using Soneta.Types;
using Soneta.Business;
using Soneta.Handel;
using Soneta.Examples.EnovaDB.Punktacja;

[assembly: ModuleType("Punktacja", typeof(Soneta.Examples.EnovaDB.Punktacja.PunktacjaModule), 2, "Punktacja", 2, VersionNumber=1)]
[assembly: SimpleRight(typeof(DefinicjaPunktu), "Edycja pola Nazwa", Description="Zezwala na edycj� pola Nazwa zapisu.")]

namespace Soneta.Examples.EnovaDB.Punktacja {

	/// <summary>
	/// Modu� Punktacja.
	/// <seealso cref="Soneta.Handel"/>
	/// </summary>
	/// <seealso cref="Soneta.Business.Module"/>
	/// <seealso cref="Soneta.Business.Session"/>
	[System.CodeDom.Compiler.GeneratedCode("Soneta.Generator", "2")]
	public partial class PunktacjaModule : Module {

		public static PunktacjaModule GetInstance(ISessionable session) {
			if (session == null || session.Session == null) return null;
			return (PunktacjaModule)session.Session.Modules[typeof(PunktacjaModule)];
		}

		/// <summary>
		/// Standardowy kontruktor modu�u sesji.
		/// </summary>
		/// <param name="session">Sesja w kt�rej jest tworzony ten modu�.</param>
		public PunktacjaModule(Session session) : base(session, "Punktacja") {
			AddTable(tableDefinicjaPunktu);
			AddTable(tablePunkt);
			Initialize();
		}

		HandelModule moduleHandel = null;

		[Browsable(false)]
		public HandelModule Handel {
			get {
				if (moduleHandel==null)
				    moduleHandel = HandelModule.GetInstance(Session);
				return moduleHandel;
			}
		}

		static int handleDefPunkty = 0;

		private DefPunkty tableDefinicjaPunktu = new DefPunkty();
		/// <summary>
		/// Tabela DefinicjaPunktu.
		/// </summary>
		/// <param name="session">Sesja w kt�rej jest tworzony ten modu�.</param>
		public DefPunkty DefPunkty {
			get { return tableDefinicjaPunktu; } 
		}

		/// <summary>
		/// Klasa implementuj�ca standardow� obs�ug� tabeli obiekt�w DefinicjaPunktu.
		/// Dziedzicz�ca klasa <see cref="DefPunkty"/> zawiera kod u�ytkownika
		/// zawieraj�cy specyficzn� funkcjonalno�� tabeli, kt�ra nie zawiera si� w funkcjonalno�ci
		/// biblioteki <see cref="Soneta.Business"/>.
		/// </summary>
		/// <seealso cref="DefPunkty"/>
		/// <seealso cref="DefinicjaPunktuRow"/>
		/// <seealso cref="DefinicjaPunktu"/>
		/// <seealso cref="Soneta.Business.Table"/>
		[TableName("DefinicjaPunktu", "Definicj", "DefPunkty", typeof(DefinicjaPunktu))]
		public abstract partial class DefinicjaPunktuTable : GuidedTable {

			protected DefinicjaPunktuTable() : base(true, false) {
			}

			public class WgNazwyKey : Key {
				protected override object [] GetData(Row row, Record rec) {
					return new object[] {
						((DefinicjaPunktuRecord)rec).Nazwa.TrimEnd()};
				}
				public WgNazwyKey(DefinicjaPunktuTable table) {
					Table = table;
					Name = "WgNazwy";
					Unique = true;
					InitFields("Nazwa");
					table.Session.Keys.Add(this);
				}

				public DefinicjaPunktu this[string nazwa] {
					get {
						return (DefinicjaPunktu)Find(nazwa);
					}
				}
			}

			WgNazwyKey keyWgNazwy;

			public WgNazwyKey WgNazwy {
				get { return keyWgNazwy; } 
			}


			protected override void LoadChildRelations() {
			}

			/// <summary>
			/// Typowane property dostarczaj�ce obiekt modu�u zawieraj�ceg� t� tabel�. Umo�liwia dost�p do
			/// innych obiekt�w znajduj�cych si� w tym samym module.
			/// </summary>
			/// <seealso cref="PunktacjaModule"/>
			public new PunktacjaModule Module {
				get { return (PunktacjaModule)base.Module; } 
			}

			/// <summary>
			/// Typowany indekser dostarczaj�cy obiekty znajduj�ce si� w tej tabeli przy pomocy 
			/// ID identyfikuj�cego jednoznacznie obiekt w systemie.
			/// </summary>
			/// <param name="id">Liczba b�d�ca unikalnym identyfikatorem obiektu. Warto�ci
			/// ujemne identyfikuj� obiekty, kt�re zosta�y dodane i nie s� jeszcze zapisane do bazy danych.</param>
			/// <seealso cref="DefinicjaPunktu"/>
			public new DefinicjaPunktu this[int id] {
				get { return (DefinicjaPunktu)base[id]; } 
			}

			public new DefinicjaPunktu this[Guid guid] {
				get { return (DefinicjaPunktu)base[guid]; } 
			}

			protected override void Adding(Module module) {
				base.Adding(module);
				keyWgNazwy = new WgNazwyKey(this);
				SetPrimaryKey(keyWgNazwy);
			}

			protected override Record CreateRecord() {
				return new DefinicjaPunktuRecord();
			}

			protected override Row CreateRow(RowCreator creator) {
				return new DefinicjaPunktu();
			}

			/// <summary>
			/// Metoda zwracaj�ca typ wierszy znajduj�cych si� w tej tabeli.
			/// </summary>
			/// <returns>Metoda zwraca zawsze warto�� typeof(DefinicjaPunktu).</returns>
			/// <seealso cref="DefinicjaPunktu"/>
			public override Type GetRowType() {
				return typeof(DefinicjaPunktu);
			}

			protected override sealed int GetTableHandle() {
				return handleDefPunkty;
			}

			protected override sealed void PrepareNames(StringBuilder names, string divider, bool prepareTextFields) {
				names.Append(divider); names.Append("Guid");
				names.Append(divider); names.Append("Nazwa");
				names.Append(divider); names.Append("Mnoznik");
			}

			protected override sealed void PrepareTypes(System.Collections.Generic.List<Type> types) {
				types.Add(typeof(Guid));
				types.Add(typeof(string));
				types.Add(typeof(int));
			}

		}

		[RecordType(typeof(DefinicjaPunktuRecord))]
		[Caption("Definicje dodatkowych punkt�w")]
		public abstract partial class DefinicjaPunktuRow : GuidedRow {

			private DefinicjaPunktuRecord record = null;


			protected override void AssignRecord(Record rec) {
				record = (DefinicjaPunktuRecord)rec;
			}

			protected DefinicjaPunktuRow() : base(true) {
			}

			[Description("Pe�na nazwa definicji punktu.")]
			[Category("Og�lne")]
			[MaxLength(30)]
			[Required]
			public string Nazwa {
				get {
					if (record==null) GetRecord();
					return record.Nazwa;
				}
				set {
					if (DefinicjaPunktuSchema.NazwaBeforeEdit!=null)
						DefinicjaPunktuSchema.NazwaBeforeEdit((DefinicjaPunktu)this, ref value);
					if (value!=null) value = value.TrimEnd();
					if (string.IsNullOrEmpty(value)) throw new RequiredException(this, "Nazwa");
					if (value.Length>NazwaLength) throw new ValueToLongException(this, "Nazwa", NazwaLength);
					if (!AllowsEditImportantFields("Nazwa")) throw new ColReadOnlyException(this, "Nazwa");
					GetEdit(record==null, false);
					record.Nazwa = value;
					if (State!=RowState.Detached) {
						Table.WgNazwy.ResyncSet(this);
						if (State==RowState.Modified) Session.Verifiers.Add(new ImportantColumnVerifier<DefinicjaPunktu>((DefinicjaPunktu)this, "Nazwa"));
					}
					if (DefinicjaPunktuSchema.NazwaAfterEdit!=null)
						DefinicjaPunktuSchema.NazwaAfterEdit((DefinicjaPunktu)this);
				}
			}

			public const int NazwaLength = 30;

			public bool IsReadOnlyNazwa() {
				return IsReadOnly() || !AllowsEditImportantFields("Nazwa");
			}

			[Description("Mno�nik punkt�w, kt�ry s�u�y do wyliczenia ilo�ci punkt�w.")]
			[Caption("Mno�nik")]
			public int Mnoznik {
				get {
					if (record==null) GetRecord();
					return record.Mnoznik;
				}
				set {
					if (DefinicjaPunktuSchema.MnoznikBeforeEdit!=null)
						DefinicjaPunktuSchema.MnoznikBeforeEdit((DefinicjaPunktu)this, ref value);
					GetEdit(record==null, false);
					record.Mnoznik = value;
					if (DefinicjaPunktuSchema.MnoznikAfterEdit!=null)
						DefinicjaPunktuSchema.MnoznikAfterEdit((DefinicjaPunktu)this);
				}
			}

			[Browsable(false)]
			public new DefPunkty Table {
				get { return (DefPunkty)base.Table; }
			}

			[Browsable(false)]
			public PunktacjaModule Module {
				get { return Table.Module; }
			}

			protected override sealed int GetTableHandle() {
				return handleDefPunkty;
			}

			protected override Record CreateRecord() {
				return new DefinicjaPunktuRecord();
			}

			public sealed override AccessRights GetObjectRight() {
				AccessRights ar = CalcObjectRight();
				if (DefinicjaPunktuSchema.OnCalcObjectRight!=null)
					DefinicjaPunktuSchema.OnCalcObjectRight((DefinicjaPunktu)this, ref ar);
				return ar;
			}

			protected sealed override AccessRights GetParentsObjectRight() {
				AccessRights result = CalcParentsObjectRight();
				if (DefinicjaPunktuSchema.OnCalcParentsObjectRight!=null)
					DefinicjaPunktuSchema.OnCalcParentsObjectRight((DefinicjaPunktu)this, ref result);
				return result;
			}

			class NazwaRequiredVerifier : RequiredVerifier {
				internal NazwaRequiredVerifier(IRow row) : base(row, "Nazwa") {
				}
				protected override bool IsValid() {
					return !(string.IsNullOrEmpty(((DefinicjaPunktuRow)Row).Nazwa));
				}
			}

			protected override void OnAdded() {
				base.OnAdded();
				Session.Verifiers.Add(new NazwaRequiredVerifier(this));
				if (DefinicjaPunktuSchema.OnAdded!=null)
					DefinicjaPunktuSchema.OnAdded((DefinicjaPunktu)this);
			}

			protected override void OnLoaded() {
				base.OnLoaded();
				if (DefinicjaPunktuSchema.OnLoaded!=null)
					DefinicjaPunktuSchema.OnLoaded((DefinicjaPunktu)this);
			}

			protected override void OnEditing() {
				base.OnEditing();
				if (DefinicjaPunktuSchema.OnEditing!=null)
					DefinicjaPunktuSchema.OnEditing((DefinicjaPunktu)this);
			}

			protected override void OnDeleting() {
				base.OnDeleting();
				if (DefinicjaPunktuSchema.OnDeleting!=null)
					DefinicjaPunktuSchema.OnDeleting((DefinicjaPunktu)this);
			}

			protected override void OnDeleted() {
				base.OnDeleted();
				if (DefinicjaPunktuSchema.OnDeleted!=null)
					DefinicjaPunktuSchema.OnDeleted((DefinicjaPunktu)this);
			}

		}

		[ParentTable("DefinicjaPunktu")]
		public sealed class DefinicjaPunktuRecord : GuidedRecord {
			[Required]
			[MaxLength(30)]
			public string Nazwa = "";
			public int Mnoznik;

			public override Record Clone() {
				DefinicjaPunktuRecord rec = (DefinicjaPunktuRecord)MemberwiseClone();
				return rec;
			}

			public override void Load(RowCreator creator, int delta) {
				System.Diagnostics.Debug.Assert(delta==0);
				Guid = creator.Load_guid(1);
				Nazwa = creator.Load_string(2);
				Mnoznik = creator.Load_int(3);
			}
		}

		public static class DefinicjaPunktuSchema {

			internal static RowDelegate<DefinicjaPunktuRow, string> NazwaBeforeEdit;
			public static void AddNazwaBeforeEdit(RowDelegate<DefinicjaPunktuRow, string> value) {
				NazwaBeforeEdit = (RowDelegate<DefinicjaPunktuRow, string>)Delegate.Combine(NazwaBeforeEdit, value);
			}

			internal static RowDelegate<DefinicjaPunktuRow> NazwaAfterEdit;
			public static void AddNazwaAfterEdit(RowDelegate<DefinicjaPunktuRow> value) {
				NazwaAfterEdit = (RowDelegate<DefinicjaPunktuRow>)Delegate.Combine(NazwaAfterEdit, value);
			}

			internal static RowDelegate<DefinicjaPunktuRow, int> MnoznikBeforeEdit;
			public static void AddMnoznikBeforeEdit(RowDelegate<DefinicjaPunktuRow, int> value) {
				MnoznikBeforeEdit = (RowDelegate<DefinicjaPunktuRow, int>)Delegate.Combine(MnoznikBeforeEdit, value);
			}

			internal static RowDelegate<DefinicjaPunktuRow> MnoznikAfterEdit;
			public static void AddMnoznikAfterEdit(RowDelegate<DefinicjaPunktuRow> value) {
				MnoznikAfterEdit = (RowDelegate<DefinicjaPunktuRow>)Delegate.Combine(MnoznikAfterEdit, value);
			}

			internal static RowDelegate<DefinicjaPunktuRow> OnLoaded;
			public static void AddOnLoaded(RowDelegate<DefinicjaPunktuRow> value) {
				OnLoaded = (RowDelegate<DefinicjaPunktuRow>)Delegate.Combine(OnLoaded, value);
			}

			internal static RowDelegate<DefinicjaPunktuRow> OnAdded;
			public static void AddOnAdded(RowDelegate<DefinicjaPunktuRow> value) {
				OnAdded = (RowDelegate<DefinicjaPunktuRow>)Delegate.Combine(OnAdded, value);
			}

			internal static RowDelegate<DefinicjaPunktuRow> OnEditing;
			public static void AddOnEditing(RowDelegate<DefinicjaPunktuRow> value) {
				OnEditing = (RowDelegate<DefinicjaPunktuRow>)Delegate.Combine(OnEditing, value);
			}

			internal static RowDelegate<DefinicjaPunktuRow> OnDeleting;
			public static void AddOnDeleting(RowDelegate<DefinicjaPunktuRow> value) {
				OnDeleting = (RowDelegate<DefinicjaPunktuRow>)Delegate.Combine(OnDeleting, value);
			}

			internal static RowDelegate<DefinicjaPunktuRow> OnDeleted;
			public static void AddOnDeleted(RowDelegate<DefinicjaPunktuRow> value) {
				OnDeleted = (RowDelegate<DefinicjaPunktuRow>)Delegate.Combine(OnDeleted, value);
			}

			internal static RowAccessRightsDelegate<DefinicjaPunktuRow> OnCalcObjectRight;
			public static void AddOnCalcObjectRight(RowAccessRightsDelegate<DefinicjaPunktuRow> value) {
				OnCalcObjectRight = (RowAccessRightsDelegate<DefinicjaPunktuRow>)Delegate.Combine(OnCalcObjectRight, value);
			}

			internal static RowAccessRightsDelegate<DefinicjaPunktuRow> OnCalcParentsObjectRight;
			public static void AddOnCalcParentsObjectRight(RowAccessRightsDelegate<DefinicjaPunktuRow> value) {
				OnCalcParentsObjectRight = (RowAccessRightsDelegate<DefinicjaPunktuRow>)Delegate.Combine(OnCalcParentsObjectRight, value);
			}

		}

		static int handlePunkty = 0;

		private Punkty tablePunkt = new Punkty();
		/// <summary>
		/// Tabela Punkt.
		/// </summary>
		/// <param name="session">Sesja w kt�rej jest tworzony ten modu�.</param>
		public Punkty Punkty {
			get { return tablePunkt; } 
		}

		/// <summary>
		/// Klasa implementuj�ca standardow� obs�ug� tabeli obiekt�w Punkt.
		/// Dziedzicz�ca klasa <see cref="Punkty"/> zawiera kod u�ytkownika
		/// zawieraj�cy specyficzn� funkcjonalno�� tabeli, kt�ra nie zawiera si� w funkcjonalno�ci
		/// biblioteki <see cref="Soneta.Business"/>.
		/// </summary>
		/// <seealso cref="Punkty"/>
		/// <seealso cref="PunktRow"/>
		/// <seealso cref="Punkt"/>
		/// <seealso cref="Soneta.Business.Table"/>
		[TableName("Punkt", "Punkt", "Punkty", typeof(Punkt))]
		public abstract partial class PunktTable : Table {

			protected PunktTable() : base(false, false) {
			}

			public class DefinicjaRelation : SimpleRelation {
				protected override object [] GetData(Row row, Record rec) {
					return new object[] {
						((PunktRecord)rec).Definicja,
						row.ID};
				}
				public DefinicjaRelation(PunktTable table) {
					Table = table;
					Name = "Definicja punktu dokumentu handlowego";
					ParentTable = table.Module.tableDefinicjaPunktu;
					ChildColumn = "Definicja";
					InitFields("Definicja", "ID");
					table.Session.Keys.Add(this);
				}

				public SubTable this[DefinicjaPunktu definicja] {
					get {
						return new SubTable(this, definicja);
					}
				}
			}

			DefinicjaRelation relationDefinicja;

			public DefinicjaRelation WgDefinicja {
				get { return relationDefinicja; } 
			}

			public class DokumentRelation : SimpleRelation {
				protected override object [] GetData(Row row, Record rec) {
					return new object[] {
						((PunktRecord)rec).Dokument,
						row.ID};
				}
				public DokumentRelation(PunktTable table) {
					Table = table;
					Name = "Punkty dokumentu handlowego";
					ParentName = "DokumentHandlowy";
					ChildColumn = "Dokument";
					DeleteCascade = true;
					Guided = RelationGuidedType.Inner;
					InitFields("Dokument", "ID");
					table.Session.Keys.Add(this);
				}

				public SubTable this[DokumentHandlowy dokument] {
					get {
						return new SubTable(this, dokument);
					}
				}
			}

			DokumentRelation relationDokument;

			public DokumentRelation WgDokument {
				get { return relationDokument; } 
			}


			protected override void LoadChildRelations() {
			}

			/// <summary>
			/// Typowane property dostarczaj�ce obiekt modu�u zawieraj�ceg� t� tabel�. Umo�liwia dost�p do
			/// innych obiekt�w znajduj�cych si� w tym samym module.
			/// </summary>
			/// <seealso cref="PunktacjaModule"/>
			public new PunktacjaModule Module {
				get { return (PunktacjaModule)base.Module; } 
			}

			/// <summary>
			/// Typowany indekser dostarczaj�cy obiekty znajduj�ce si� w tej tabeli przy pomocy 
			/// ID identyfikuj�cego jednoznacznie obiekt w systemie.
			/// </summary>
			/// <param name="id">Liczba b�d�ca unikalnym identyfikatorem obiektu. Warto�ci
			/// ujemne identyfikuj� obiekty, kt�re zosta�y dodane i nie s� jeszcze zapisane do bazy danych.</param>
			/// <seealso cref="Punkt"/>
			public new Punkt this[int id] {
				get { return (Punkt)base[id]; } 
			}

			protected override void Adding(Module module) {
				base.Adding(module);
				relationDefinicja = new DefinicjaRelation(this);
				relationDokument = new DokumentRelation(this);
				SetPrimaryKey(relationDokument);
			}

			protected override Record CreateRecord() {
				return new PunktRecord();
			}

			protected override Row CreateRow(RowCreator creator) {
				return new Punkt(creator);
			}

			/// <summary>
			/// Metoda zwracaj�ca typ wierszy znajduj�cych si� w tej tabeli.
			/// </summary>
			/// <returns>Metoda zwraca zawsze warto�� typeof(Punkt).</returns>
			/// <seealso cref="Punkt"/>
			public override Type GetRowType() {
				return typeof(Punkt);
			}

			protected override sealed int GetTableHandle() {
				return handlePunkty;
			}

			protected override sealed void PrepareNames(StringBuilder names, string divider, bool prepareTextFields) {
				names.Append(divider); names.Append("Definicja");
				names.Append(divider); names.Append("Dokument");
				names.Append(divider); names.Append("Liczba");
			}

			protected override sealed void PrepareTypes(System.Collections.Generic.List<Type> types) {
				types.Add(typeof(Row));
				types.Add(typeof(Row));
				types.Add(typeof(int));
			}

		}

		[RecordType(typeof(PunktRecord))]
		[Caption("Dodatkowe punkty")]
		public abstract partial class PunktRow : Row {

			private PunktRecord record = null;


			protected override void AssignRecord(Record rec) {
				record = (PunktRecord)rec;
			}

			protected PunktRow(RowCreator creator) : base(false) {
			}

			protected PunktRow([Required] DokumentHandlowy dokument) : base(true) {
				if (dokument==null) throw new RequiredException(this, "Dokument");
				GetRecord();
				record.Dokument = dokument;
			}

			[Description("Okre�la rodzaj przypisanego punktu.")]
			[Category("Og�lne")]
			[Required]
			public DefinicjaPunktu Definicja {
				get {
					if (record==null) GetRecord();
					if (record.Definicja==null) return null;
					DefinicjaPunktu row = (DefinicjaPunktu)record.Definicja.Root;
					record.Definicja = row;
					return row;
				}
				set {
					if (PunktSchema.DefinicjaBeforeEdit!=null)
						PunktSchema.DefinicjaBeforeEdit((Punkt)this, ref value);
					System.Diagnostics.Debug.Assert(value==null || State==RowState.Detached || value.State==RowState.Detached || Session==value.Session);
					GetEdit(record==null, false);
					if (value==null) throw new RequiredException(this, "Definicja");
					record.Definicja = value;
					if (State!=RowState.Detached) {
						Table.WgDefinicja.ResyncSet(this);
					}
					if (PunktSchema.DefinicjaAfterEdit!=null)
						PunktSchema.DefinicjaAfterEdit((Punkt)this);
				}
			}

			[Description("Dokument handlowy, kt�remu przypisany jest dany punkt.")]
			[Category("Og�lne")]
			[Required]
			public DokumentHandlowy Dokument {
				get {
					if (record==null) GetRecord();
					if (record.Dokument==null) return null;
					DokumentHandlowy row = (DokumentHandlowy)record.Dokument.Root;
					record.Dokument = row;
					return row;
				}
			}

			[Description("Ilo�� przypisanych punkt�w.")]
			public int Liczba {
				get {
					if (record==null) GetRecord();
					return record.Liczba;
				}
				set {
					if (PunktSchema.LiczbaBeforeEdit!=null)
						PunktSchema.LiczbaBeforeEdit((Punkt)this, ref value);
					GetEdit(record==null, false);
					record.Liczba = value;
					if (PunktSchema.LiczbaAfterEdit!=null)
						PunktSchema.LiczbaAfterEdit((Punkt)this);
				}
			}

			[Browsable(false)]
			public new Punkty Table {
				get { return (Punkty)base.Table; }
			}

			[Browsable(false)]
			public PunktacjaModule Module {
				get { return Table.Module; }
			}

			protected override sealed int GetTableHandle() {
				return handlePunkty;
			}

			protected override Record CreateRecord() {
				return new PunktRecord();
			}

			public sealed override AccessRights GetObjectRight() {
				AccessRights ar = CalcObjectRight();
				if (PunktSchema.OnCalcObjectRight!=null)
					PunktSchema.OnCalcObjectRight((Punkt)this, ref ar);
				return ar;
			}

			protected sealed override AccessRights GetParentsObjectRight() {
				AccessRights result = CalcParentsObjectRight();
				if (PunktSchema.OnCalcParentsObjectRight!=null)
					PunktSchema.OnCalcParentsObjectRight((Punkt)this, ref result);
				return result;
			}

			class DefinicjaRequiredVerifier : RequiredVerifier {
				internal DefinicjaRequiredVerifier(IRow row) : base(row, "Definicja") {
				}
				protected override bool IsValid() {
					return ((PunktRow)Row).Definicja!=null;
				}
			}

			protected override void OnAdded() {
				base.OnAdded();
				Session.Verifiers.Add(new DefinicjaRequiredVerifier(this));
				System.Diagnostics.Debug.Assert(record.Definicja==null || record.Definicja.State==RowState.Detached || Session==record.Definicja.Session);
				System.Diagnostics.Debug.Assert(record.Dokument==null || record.Dokument.State==RowState.Detached || Session==record.Dokument.Session);
				if (PunktSchema.OnAdded!=null)
					PunktSchema.OnAdded((Punkt)this);
			}

			protected override void OnLoaded() {
				base.OnLoaded();
				if (PunktSchema.OnLoaded!=null)
					PunktSchema.OnLoaded((Punkt)this);
			}

			protected override void OnEditing() {
				base.OnEditing();
				if (PunktSchema.OnEditing!=null)
					PunktSchema.OnEditing((Punkt)this);
			}

			protected override void OnDeleting() {
				base.OnDeleting();
				if (PunktSchema.OnDeleting!=null)
					PunktSchema.OnDeleting((Punkt)this);
			}

			protected override void OnDeleted() {
				base.OnDeleted();
				if (PunktSchema.OnDeleted!=null)
					PunktSchema.OnDeleted((Punkt)this);
			}

			protected override void LockGuidedRoot() {
				//System.Diagnostics.Debug.Assert(Dokument!=null, "Nie istnieje rekord guided root dla rekordu typu: "+GetType());
				if(Dokument!=null)
				((Row)Dokument).SetEdit(false);
			}

			public override GuidedRow GetGuidedRoot() {
				Row r = (Row)Dokument;
				return r==null ? null : r.GetGuidedRoot();
			}

		}

		[ParentTable("Punkt")]
		public sealed class PunktRecord : Record {
			[Required]
			[ParentTable("DefinicjaPunktu")]
			public IRow Definicja;
			[Required]
			[ParentTable("DokumentHandlowy")]
			public IRow Dokument;
			public int Liczba;

			public override Record Clone() {
				PunktRecord rec = (PunktRecord)MemberwiseClone();
				return rec;
			}

			public override void Load(RowCreator creator, int delta) {
				System.Diagnostics.Debug.Assert(delta==0);
				Definicja = creator.Load_Row(1, "DefPunkty");
				Dokument = creator.Load_Row(2, "DokHandlowe");
				Liczba = creator.Load_int(3);
			}
		}

		public static class PunktSchema {

			internal static RowDelegate<PunktRow, DefinicjaPunktu> DefinicjaBeforeEdit;
			public static void AddDefinicjaBeforeEdit(RowDelegate<PunktRow, DefinicjaPunktu> value) {
				DefinicjaBeforeEdit = (RowDelegate<PunktRow, DefinicjaPunktu>)Delegate.Combine(DefinicjaBeforeEdit, value);
			}

			internal static RowDelegate<PunktRow> DefinicjaAfterEdit;
			public static void AddDefinicjaAfterEdit(RowDelegate<PunktRow> value) {
				DefinicjaAfterEdit = (RowDelegate<PunktRow>)Delegate.Combine(DefinicjaAfterEdit, value);
			}

			internal static RowDelegate<PunktRow, int> LiczbaBeforeEdit;
			public static void AddLiczbaBeforeEdit(RowDelegate<PunktRow, int> value) {
				LiczbaBeforeEdit = (RowDelegate<PunktRow, int>)Delegate.Combine(LiczbaBeforeEdit, value);
			}

			internal static RowDelegate<PunktRow> LiczbaAfterEdit;
			public static void AddLiczbaAfterEdit(RowDelegate<PunktRow> value) {
				LiczbaAfterEdit = (RowDelegate<PunktRow>)Delegate.Combine(LiczbaAfterEdit, value);
			}

			internal static RowDelegate<PunktRow> OnLoaded;
			public static void AddOnLoaded(RowDelegate<PunktRow> value) {
				OnLoaded = (RowDelegate<PunktRow>)Delegate.Combine(OnLoaded, value);
			}

			internal static RowDelegate<PunktRow> OnAdded;
			public static void AddOnAdded(RowDelegate<PunktRow> value) {
				OnAdded = (RowDelegate<PunktRow>)Delegate.Combine(OnAdded, value);
			}

			internal static RowDelegate<PunktRow> OnEditing;
			public static void AddOnEditing(RowDelegate<PunktRow> value) {
				OnEditing = (RowDelegate<PunktRow>)Delegate.Combine(OnEditing, value);
			}

			internal static RowDelegate<PunktRow> OnDeleting;
			public static void AddOnDeleting(RowDelegate<PunktRow> value) {
				OnDeleting = (RowDelegate<PunktRow>)Delegate.Combine(OnDeleting, value);
			}

			internal static RowDelegate<PunktRow> OnDeleted;
			public static void AddOnDeleted(RowDelegate<PunktRow> value) {
				OnDeleted = (RowDelegate<PunktRow>)Delegate.Combine(OnDeleted, value);
			}

			internal static RowAccessRightsDelegate<PunktRow> OnCalcObjectRight;
			public static void AddOnCalcObjectRight(RowAccessRightsDelegate<PunktRow> value) {
				OnCalcObjectRight = (RowAccessRightsDelegate<PunktRow>)Delegate.Combine(OnCalcObjectRight, value);
			}

			internal static RowAccessRightsDelegate<PunktRow> OnCalcParentsObjectRight;
			public static void AddOnCalcParentsObjectRight(RowAccessRightsDelegate<PunktRow> value) {
				OnCalcParentsObjectRight = (RowAccessRightsDelegate<PunktRow>)Delegate.Combine(OnCalcParentsObjectRight, value);
			}

		}

	}
}

