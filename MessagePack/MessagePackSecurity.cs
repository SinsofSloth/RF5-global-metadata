public class MessagePackSecurity // TypeDefIndex: 5136
{
	// Fields
	public static readonly MessagePackSecurity TrustedData; // 0x0
	public static readonly MessagePackSecurity UntrustedData; // 0x8
	private readonly MessagePackSecurity.ObjectFallbackEqualityComparer objectFallbackEqualityComparer; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x139920 Offset: 0x139A21 VA: 0x139920
	private bool <HashCollisionResistant>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x139930 Offset: 0x139A31 VA: 0x139930
	private int <MaximumObjectGraphDepth>k__BackingField; // 0x1C

	// Properties
	public bool HashCollisionResistant { get; set; }
	public int MaximumObjectGraphDepth { get; set; }

	// Methods

	// RVA: 0x1691710 Offset: 0x1691811 VA: 0x1691710
	private void .ctor() { }

	// RVA: 0x1691880 Offset: 0x1691981 VA: 0x1691880
	protected void .ctor(MessagePackSecurity copyFrom) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A020 Offset: 0x13A121 VA: 0x13A020
	// RVA: 0x1691980 Offset: 0x1691A81 VA: 0x1691980
	public bool get_HashCollisionResistant() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A030 Offset: 0x13A131 VA: 0x13A030
	// RVA: 0x1691990 Offset: 0x1691A91 VA: 0x1691990
	private void set_HashCollisionResistant(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A040 Offset: 0x13A141 VA: 0x13A040
	// RVA: 0x16919A0 Offset: 0x1691AA1 VA: 0x16919A0
	public int get_MaximumObjectGraphDepth() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A050 Offset: 0x13A151 VA: 0x13A050
	// RVA: 0x16919B0 Offset: 0x1691AB1 VA: 0x16919B0
	private void set_MaximumObjectGraphDepth(int value) { }

	// RVA: 0x16919C0 Offset: 0x1691AC1 VA: 0x16919C0
	public MessagePackSecurity WithMaximumObjectGraphDepth(int maximumObjectGraphDepth) { }

	// RVA: 0x1691A00 Offset: 0x1691B01 VA: 0x1691A00
	public MessagePackSecurity WithHashCollisionResistant(bool hashCollisionResistant) { }

	// RVA: -1 Offset: -1
	public IEqualityComparer<T> GetEqualityComparer<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21A9760 Offset: 0x21A9861 VA: 0x21A9760
	|-MessagePackSecurity.GetEqualityComparer<object>
	*/

	// RVA: 0x1691A50 Offset: 0x1691B51 VA: 0x1691A50
	public IEqualityComparer GetEqualityComparer() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual IEqualityComparer<T> GetHashCollisionResistantEqualityComparer<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21A97D0 Offset: 0x21A98D1 VA: 0x21A97D0
	|-MessagePackSecurity.GetHashCollisionResistantEqualityComparer<object>
	*/

	// RVA: 0x1691AC0 Offset: 0x1691BC1 VA: 0x1691AC0
	public void DepthStep(ref MessagePackReader reader) { }

	// RVA: 0x1691B90 Offset: 0x1691C91 VA: 0x1691B90 Slot: 5
	protected virtual IEqualityComparer GetHashCollisionResistantEqualityComparer() { }

	// RVA: 0x1691C30 Offset: 0x1691D31 VA: 0x1691C30 Slot: 6
	protected virtual MessagePackSecurity Clone() { }

	// RVA: 0x1691C90 Offset: 0x1691D91 VA: 0x1691C90
	private static void .cctor() { }
}

public class MessagePackSecurity // TypeDefIndex: 5136
{
	// Fields
	public static readonly MessagePackSecurity TrustedData; // 0x0
	public static readonly MessagePackSecurity UntrustedData; // 0x8
	private readonly MessagePackSecurity.ObjectFallbackEqualityComparer objectFallbackEqualityComparer; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x139920 Offset: 0x139A21 VA: 0x139920
	private bool <HashCollisionResistant>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x139930 Offset: 0x139A31 VA: 0x139930
	private int <MaximumObjectGraphDepth>k__BackingField; // 0x1C

	// Properties
	public bool HashCollisionResistant { get; set; }
	public int MaximumObjectGraphDepth { get; set; }

	// Methods

	// RVA: 0x1691710 Offset: 0x1691811 VA: 0x1691710
	private void .ctor() { }

	// RVA: 0x1691880 Offset: 0x1691981 VA: 0x1691880
	protected void .ctor(MessagePackSecurity copyFrom) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A020 Offset: 0x13A121 VA: 0x13A020
	// RVA: 0x1691980 Offset: 0x1691A81 VA: 0x1691980
	public bool get_HashCollisionResistant() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A030 Offset: 0x13A131 VA: 0x13A030
	// RVA: 0x1691990 Offset: 0x1691A91 VA: 0x1691990
	private void set_HashCollisionResistant(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A040 Offset: 0x13A141 VA: 0x13A040
	// RVA: 0x16919A0 Offset: 0x1691AA1 VA: 0x16919A0
	public int get_MaximumObjectGraphDepth() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A050 Offset: 0x13A151 VA: 0x13A050
	// RVA: 0x16919B0 Offset: 0x1691AB1 VA: 0x16919B0
	private void set_MaximumObjectGraphDepth(int value) { }

	// RVA: 0x16919C0 Offset: 0x1691AC1 VA: 0x16919C0
	public MessagePackSecurity WithMaximumObjectGraphDepth(int maximumObjectGraphDepth) { }

	// RVA: 0x1691A00 Offset: 0x1691B01 VA: 0x1691A00
	public MessagePackSecurity WithHashCollisionResistant(bool hashCollisionResistant) { }

	// RVA: -1 Offset: -1
	public IEqualityComparer<T> GetEqualityComparer<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21A9760 Offset: 0x21A9861 VA: 0x21A9760
	|-MessagePackSecurity.GetEqualityComparer<object>
	*/

	// RVA: 0x1691A50 Offset: 0x1691B51 VA: 0x1691A50
	public IEqualityComparer GetEqualityComparer() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual IEqualityComparer<T> GetHashCollisionResistantEqualityComparer<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21A97D0 Offset: 0x21A98D1 VA: 0x21A97D0
	|-MessagePackSecurity.GetHashCollisionResistantEqualityComparer<object>
	*/

	// RVA: 0x1691AC0 Offset: 0x1691BC1 VA: 0x1691AC0
	public void DepthStep(ref MessagePackReader reader) { }

	// RVA: 0x1691B90 Offset: 0x1691C91 VA: 0x1691B90 Slot: 5
	protected virtual IEqualityComparer GetHashCollisionResistantEqualityComparer() { }

	// RVA: 0x1691C30 Offset: 0x1691D31 VA: 0x1691C30 Slot: 6
	protected virtual MessagePackSecurity Clone() { }

	// RVA: 0x1691C90 Offset: 0x1691D91 VA: 0x1691C90
	private static void .cctor() { }
}

public class MessagePackSecurity // TypeDefIndex: 5136
{
	// Fields
	public static readonly MessagePackSecurity TrustedData; // 0x0
	public static readonly MessagePackSecurity UntrustedData; // 0x8
	private readonly MessagePackSecurity.ObjectFallbackEqualityComparer objectFallbackEqualityComparer; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x139920 Offset: 0x139A21 VA: 0x139920
	private bool <HashCollisionResistant>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x139930 Offset: 0x139A31 VA: 0x139930
	private int <MaximumObjectGraphDepth>k__BackingField; // 0x1C

	// Properties
	public bool HashCollisionResistant { get; set; }
	public int MaximumObjectGraphDepth { get; set; }

	// Methods

	// RVA: 0x1691710 Offset: 0x1691811 VA: 0x1691710
	private void .ctor() { }

	// RVA: 0x1691880 Offset: 0x1691981 VA: 0x1691880
	protected void .ctor(MessagePackSecurity copyFrom) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A020 Offset: 0x13A121 VA: 0x13A020
	// RVA: 0x1691980 Offset: 0x1691A81 VA: 0x1691980
	public bool get_HashCollisionResistant() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A030 Offset: 0x13A131 VA: 0x13A030
	// RVA: 0x1691990 Offset: 0x1691A91 VA: 0x1691990
	private void set_HashCollisionResistant(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A040 Offset: 0x13A141 VA: 0x13A040
	// RVA: 0x16919A0 Offset: 0x1691AA1 VA: 0x16919A0
	public int get_MaximumObjectGraphDepth() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A050 Offset: 0x13A151 VA: 0x13A050
	// RVA: 0x16919B0 Offset: 0x1691AB1 VA: 0x16919B0
	private void set_MaximumObjectGraphDepth(int value) { }

	// RVA: 0x16919C0 Offset: 0x1691AC1 VA: 0x16919C0
	public MessagePackSecurity WithMaximumObjectGraphDepth(int maximumObjectGraphDepth) { }

	// RVA: 0x1691A00 Offset: 0x1691B01 VA: 0x1691A00
	public MessagePackSecurity WithHashCollisionResistant(bool hashCollisionResistant) { }

	// RVA: -1 Offset: -1
	public IEqualityComparer<T> GetEqualityComparer<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21A9760 Offset: 0x21A9861 VA: 0x21A9760
	|-MessagePackSecurity.GetEqualityComparer<object>
	*/

	// RVA: 0x1691A50 Offset: 0x1691B51 VA: 0x1691A50
	public IEqualityComparer GetEqualityComparer() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual IEqualityComparer<T> GetHashCollisionResistantEqualityComparer<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21A97D0 Offset: 0x21A98D1 VA: 0x21A97D0
	|-MessagePackSecurity.GetHashCollisionResistantEqualityComparer<object>
	*/

	// RVA: 0x1691AC0 Offset: 0x1691BC1 VA: 0x1691AC0
	public void DepthStep(ref MessagePackReader reader) { }

	// RVA: 0x1691B90 Offset: 0x1691C91 VA: 0x1691B90 Slot: 5
	protected virtual IEqualityComparer GetHashCollisionResistantEqualityComparer() { }

	// RVA: 0x1691C30 Offset: 0x1691D31 VA: 0x1691C30 Slot: 6
	protected virtual MessagePackSecurity Clone() { }

	// RVA: 0x1691C90 Offset: 0x1691D91 VA: 0x1691C90
	private static void .cctor() { }
}

public class MessagePackSecurity // TypeDefIndex: 5136
{
	// Fields
	public static readonly MessagePackSecurity TrustedData; // 0x0
	public static readonly MessagePackSecurity UntrustedData; // 0x8
	private readonly MessagePackSecurity.ObjectFallbackEqualityComparer objectFallbackEqualityComparer; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x139920 Offset: 0x139A21 VA: 0x139920
	private bool <HashCollisionResistant>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x139930 Offset: 0x139A31 VA: 0x139930
	private int <MaximumObjectGraphDepth>k__BackingField; // 0x1C

	// Properties
	public bool HashCollisionResistant { get; set; }
	public int MaximumObjectGraphDepth { get; set; }

	// Methods

	// RVA: 0x1691710 Offset: 0x1691811 VA: 0x1691710
	private void .ctor() { }

	// RVA: 0x1691880 Offset: 0x1691981 VA: 0x1691880
	protected void .ctor(MessagePackSecurity copyFrom) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A020 Offset: 0x13A121 VA: 0x13A020
	// RVA: 0x1691980 Offset: 0x1691A81 VA: 0x1691980
	public bool get_HashCollisionResistant() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A030 Offset: 0x13A131 VA: 0x13A030
	// RVA: 0x1691990 Offset: 0x1691A91 VA: 0x1691990
	private void set_HashCollisionResistant(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A040 Offset: 0x13A141 VA: 0x13A040
	// RVA: 0x16919A0 Offset: 0x1691AA1 VA: 0x16919A0
	public int get_MaximumObjectGraphDepth() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A050 Offset: 0x13A151 VA: 0x13A050
	// RVA: 0x16919B0 Offset: 0x1691AB1 VA: 0x16919B0
	private void set_MaximumObjectGraphDepth(int value) { }

	// RVA: 0x16919C0 Offset: 0x1691AC1 VA: 0x16919C0
	public MessagePackSecurity WithMaximumObjectGraphDepth(int maximumObjectGraphDepth) { }

	// RVA: 0x1691A00 Offset: 0x1691B01 VA: 0x1691A00
	public MessagePackSecurity WithHashCollisionResistant(bool hashCollisionResistant) { }

	// RVA: -1 Offset: -1
	public IEqualityComparer<T> GetEqualityComparer<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21A9760 Offset: 0x21A9861 VA: 0x21A9760
	|-MessagePackSecurity.GetEqualityComparer<object>
	*/

	// RVA: 0x1691A50 Offset: 0x1691B51 VA: 0x1691A50
	public IEqualityComparer GetEqualityComparer() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual IEqualityComparer<T> GetHashCollisionResistantEqualityComparer<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21A97D0 Offset: 0x21A98D1 VA: 0x21A97D0
	|-MessagePackSecurity.GetHashCollisionResistantEqualityComparer<object>
	*/

	// RVA: 0x1691AC0 Offset: 0x1691BC1 VA: 0x1691AC0
	public void DepthStep(ref MessagePackReader reader) { }

	// RVA: 0x1691B90 Offset: 0x1691C91 VA: 0x1691B90 Slot: 5
	protected virtual IEqualityComparer GetHashCollisionResistantEqualityComparer() { }

	// RVA: 0x1691C30 Offset: 0x1691D31 VA: 0x1691C30 Slot: 6
	protected virtual MessagePackSecurity Clone() { }

	// RVA: 0x1691C90 Offset: 0x1691D91 VA: 0x1691C90
	private static void .cctor() { }
}

public class MessagePackSecurity // TypeDefIndex: 5136
{
	// Fields
	public static readonly MessagePackSecurity TrustedData; // 0x0
	public static readonly MessagePackSecurity UntrustedData; // 0x8
	private readonly MessagePackSecurity.ObjectFallbackEqualityComparer objectFallbackEqualityComparer; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x139920 Offset: 0x139A21 VA: 0x139920
	private bool <HashCollisionResistant>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x139930 Offset: 0x139A31 VA: 0x139930
	private int <MaximumObjectGraphDepth>k__BackingField; // 0x1C

	// Properties
	public bool HashCollisionResistant { get; set; }
	public int MaximumObjectGraphDepth { get; set; }

	// Methods

	// RVA: 0x1691710 Offset: 0x1691811 VA: 0x1691710
	private void .ctor() { }

	// RVA: 0x1691880 Offset: 0x1691981 VA: 0x1691880
	protected void .ctor(MessagePackSecurity copyFrom) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A020 Offset: 0x13A121 VA: 0x13A020
	// RVA: 0x1691980 Offset: 0x1691A81 VA: 0x1691980
	public bool get_HashCollisionResistant() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A030 Offset: 0x13A131 VA: 0x13A030
	// RVA: 0x1691990 Offset: 0x1691A91 VA: 0x1691990
	private void set_HashCollisionResistant(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A040 Offset: 0x13A141 VA: 0x13A040
	// RVA: 0x16919A0 Offset: 0x1691AA1 VA: 0x16919A0
	public int get_MaximumObjectGraphDepth() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A050 Offset: 0x13A151 VA: 0x13A050
	// RVA: 0x16919B0 Offset: 0x1691AB1 VA: 0x16919B0
	private void set_MaximumObjectGraphDepth(int value) { }

	// RVA: 0x16919C0 Offset: 0x1691AC1 VA: 0x16919C0
	public MessagePackSecurity WithMaximumObjectGraphDepth(int maximumObjectGraphDepth) { }

	// RVA: 0x1691A00 Offset: 0x1691B01 VA: 0x1691A00
	public MessagePackSecurity WithHashCollisionResistant(bool hashCollisionResistant) { }

	// RVA: -1 Offset: -1
	public IEqualityComparer<T> GetEqualityComparer<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21A9760 Offset: 0x21A9861 VA: 0x21A9760
	|-MessagePackSecurity.GetEqualityComparer<object>
	*/

	// RVA: 0x1691A50 Offset: 0x1691B51 VA: 0x1691A50
	public IEqualityComparer GetEqualityComparer() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual IEqualityComparer<T> GetHashCollisionResistantEqualityComparer<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21A97D0 Offset: 0x21A98D1 VA: 0x21A97D0
	|-MessagePackSecurity.GetHashCollisionResistantEqualityComparer<object>
	*/

	// RVA: 0x1691AC0 Offset: 0x1691BC1 VA: 0x1691AC0
	public void DepthStep(ref MessagePackReader reader) { }

	// RVA: 0x1691B90 Offset: 0x1691C91 VA: 0x1691B90 Slot: 5
	protected virtual IEqualityComparer GetHashCollisionResistantEqualityComparer() { }

	// RVA: 0x1691C30 Offset: 0x1691D31 VA: 0x1691C30 Slot: 6
	protected virtual MessagePackSecurity Clone() { }

	// RVA: 0x1691C90 Offset: 0x1691D91 VA: 0x1691C90
	private static void .cctor() { }
}

public class MessagePackSecurity // TypeDefIndex: 5136
{
	// Fields
	public static readonly MessagePackSecurity TrustedData; // 0x0
	public static readonly MessagePackSecurity UntrustedData; // 0x8
	private readonly MessagePackSecurity.ObjectFallbackEqualityComparer objectFallbackEqualityComparer; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x139920 Offset: 0x139A21 VA: 0x139920
	private bool <HashCollisionResistant>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x139930 Offset: 0x139A31 VA: 0x139930
	private int <MaximumObjectGraphDepth>k__BackingField; // 0x1C

	// Properties
	public bool HashCollisionResistant { get; set; }
	public int MaximumObjectGraphDepth { get; set; }

	// Methods

	// RVA: 0x1691710 Offset: 0x1691811 VA: 0x1691710
	private void .ctor() { }

	// RVA: 0x1691880 Offset: 0x1691981 VA: 0x1691880
	protected void .ctor(MessagePackSecurity copyFrom) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A020 Offset: 0x13A121 VA: 0x13A020
	// RVA: 0x1691980 Offset: 0x1691A81 VA: 0x1691980
	public bool get_HashCollisionResistant() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A030 Offset: 0x13A131 VA: 0x13A030
	// RVA: 0x1691990 Offset: 0x1691A91 VA: 0x1691990
	private void set_HashCollisionResistant(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13A040 Offset: 0x13A141 VA: 0x13A040
	// RVA: 0x16919A0 Offset: 0x1691AA1 VA: 0x16919A0
	public int get_MaximumObjectGraphDepth() { }

	[CompilerGeneratedAttribute] // RVA: 0x13A050 Offset: 0x13A151 VA: 0x13A050
	// RVA: 0x16919B0 Offset: 0x1691AB1 VA: 0x16919B0
	private void set_MaximumObjectGraphDepth(int value) { }

	// RVA: 0x16919C0 Offset: 0x1691AC1 VA: 0x16919C0
	public MessagePackSecurity WithMaximumObjectGraphDepth(int maximumObjectGraphDepth) { }

	// RVA: 0x1691A00 Offset: 0x1691B01 VA: 0x1691A00
	public MessagePackSecurity WithHashCollisionResistant(bool hashCollisionResistant) { }

	// RVA: -1 Offset: -1
	public IEqualityComparer<T> GetEqualityComparer<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21A9760 Offset: 0x21A9861 VA: 0x21A9760
	|-MessagePackSecurity.GetEqualityComparer<object>
	*/

	// RVA: 0x1691A50 Offset: 0x1691B51 VA: 0x1691A50
	public IEqualityComparer GetEqualityComparer() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual IEqualityComparer<T> GetHashCollisionResistantEqualityComparer<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21A97D0 Offset: 0x21A98D1 VA: 0x21A97D0
	|-MessagePackSecurity.GetHashCollisionResistantEqualityComparer<object>
	*/

	// RVA: 0x1691AC0 Offset: 0x1691BC1 VA: 0x1691AC0
	public void DepthStep(ref MessagePackReader reader) { }

	// RVA: 0x1691B90 Offset: 0x1691C91 VA: 0x1691B90 Slot: 5
	protected virtual IEqualityComparer GetHashCollisionResistantEqualityComparer() { }

	// RVA: 0x1691C30 Offset: 0x1691D31 VA: 0x1691C30 Slot: 6
	protected virtual MessagePackSecurity Clone() { }

	// RVA: 0x1691C90 Offset: 0x1691D91 VA: 0x1691C90
	private static void .cctor() { }
}

