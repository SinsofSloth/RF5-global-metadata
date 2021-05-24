[ComVisibleAttribute] // RVA: 0xADAA0 Offset: 0xADBA1 VA: 0xADAA0
public class ManifestResourceInfo // TypeDefIndex: 542
{
	// Fields
	private Assembly _containingAssembly; // 0x10
	private string _containingFileName; // 0x18
	private ResourceLocation _resourceLocation; // 0x20

	// Properties
	public virtual Assembly ReferencedAssembly { get; }
	public virtual string FileName { get; }
	public virtual ResourceLocation ResourceLocation { get; }

	// Methods

	// RVA: 0x1959A20 Offset: 0x1959B21 VA: 0x1959A20
	public void .ctor(Assembly containingAssembly, string containingFileName, ResourceLocation resourceLocation) { }

	// RVA: 0x19687E0 Offset: 0x19688E1 VA: 0x19687E0 Slot: 4
	public virtual Assembly get_ReferencedAssembly() { }

	// RVA: 0x19687F0 Offset: 0x19688F1 VA: 0x19687F0 Slot: 5
	public virtual string get_FileName() { }

	// RVA: 0x1968800 Offset: 0x1968901 VA: 0x1968800 Slot: 6
	public virtual ResourceLocation get_ResourceLocation() { }
}

