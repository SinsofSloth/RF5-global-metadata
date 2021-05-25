public interface SmallXmlParser.IAttrList // TypeDefIndex: 25
{
	// Properties
	public abstract int Length { get; }
	public abstract string[] Names { get; }
	public abstract string[] Values { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Length() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetName(int i) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string GetValue(int i) { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string GetValue(string name) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string[] get_Names() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string[] get_Values() { }
}

