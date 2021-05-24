[ComVisibleAttribute] // RVA: 0xB0270 Offset: 0xB0371 VA: 0xB0270
public class SHA256Managed : SHA256 // TypeDefIndex: 961
{
	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateSHA256; // 0x38
	private uint[] _W; // 0x40
	private static readonly uint[] _K; // 0x0

	// Methods

	// RVA: 0x26340E0 Offset: 0x26341E1 VA: 0x26340E0
	public void .ctor() { }

	// RVA: 0x2634320 Offset: 0x2634421 VA: 0x2634320 Slot: 16
	public override void Initialize() { }

	// RVA: 0x2634370 Offset: 0x2634471 VA: 0x2634370 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x2634590 Offset: 0x2634691 VA: 0x2634590 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x2634200 Offset: 0x2634301 VA: 0x2634200
	private void InitializeState() { }

	// RVA: 0x2634380 Offset: 0x2634481 VA: 0x2634380
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x26345A0 Offset: 0x26346A1 VA: 0x26345A0
	private byte[] _EndHash() { }

	// RVA: 0x2634770 Offset: 0x2634871 VA: 0x2634770
	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

	// RVA: 0x2635480 Offset: 0x2635581 VA: 0x2635480
	private static uint RotateRight(uint x, int n) { }

	// RVA: 0x26353E0 Offset: 0x26354E1 VA: 0x26353E0
	private static uint Ch(uint x, uint y, uint z) { }

	// RVA: 0x2635460 Offset: 0x2635561 VA: 0x2635460
	private static uint Maj(uint x, uint y, uint z) { }

	// RVA: 0x2635490 Offset: 0x2635591 VA: 0x2635490
	private static uint sigma_0(uint x) { }

	// RVA: 0x2635500 Offset: 0x2635601 VA: 0x2635500
	private static uint sigma_1(uint x) { }

	// RVA: 0x26353F0 Offset: 0x26354F1 VA: 0x26353F0
	private static uint Sigma_0(uint x) { }

	// RVA: 0x2635370 Offset: 0x2635471 VA: 0x2635370
	private static uint Sigma_1(uint x) { }

	// RVA: 0x2635200 Offset: 0x2635301 VA: 0x2635200
	private static void SHA256Expand(uint* x) { }

	// RVA: 0x2635570 Offset: 0x2635671 VA: 0x2635570
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xB0270 Offset: 0xB0371 VA: 0xB0270
public class SHA256Managed : SHA256 // TypeDefIndex: 961
{
	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateSHA256; // 0x38
	private uint[] _W; // 0x40
	private static readonly uint[] _K; // 0x0

	// Methods

	// RVA: 0x26340E0 Offset: 0x26341E1 VA: 0x26340E0
	public void .ctor() { }

	// RVA: 0x2634320 Offset: 0x2634421 VA: 0x2634320 Slot: 16
	public override void Initialize() { }

	// RVA: 0x2634370 Offset: 0x2634471 VA: 0x2634370 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x2634590 Offset: 0x2634691 VA: 0x2634590 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x2634200 Offset: 0x2634301 VA: 0x2634200
	private void InitializeState() { }

	// RVA: 0x2634380 Offset: 0x2634481 VA: 0x2634380
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x26345A0 Offset: 0x26346A1 VA: 0x26345A0
	private byte[] _EndHash() { }

	// RVA: 0x2634770 Offset: 0x2634871 VA: 0x2634770
	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

	// RVA: 0x2635480 Offset: 0x2635581 VA: 0x2635480
	private static uint RotateRight(uint x, int n) { }

	// RVA: 0x26353E0 Offset: 0x26354E1 VA: 0x26353E0
	private static uint Ch(uint x, uint y, uint z) { }

	// RVA: 0x2635460 Offset: 0x2635561 VA: 0x2635460
	private static uint Maj(uint x, uint y, uint z) { }

	// RVA: 0x2635490 Offset: 0x2635591 VA: 0x2635490
	private static uint sigma_0(uint x) { }

	// RVA: 0x2635500 Offset: 0x2635601 VA: 0x2635500
	private static uint sigma_1(uint x) { }

	// RVA: 0x26353F0 Offset: 0x26354F1 VA: 0x26353F0
	private static uint Sigma_0(uint x) { }

	// RVA: 0x2635370 Offset: 0x2635471 VA: 0x2635370
	private static uint Sigma_1(uint x) { }

	// RVA: 0x2635200 Offset: 0x2635301 VA: 0x2635200
	private static void SHA256Expand(uint* x) { }

	// RVA: 0x2635570 Offset: 0x2635671 VA: 0x2635570
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xB0270 Offset: 0xB0371 VA: 0xB0270
public class SHA256Managed : SHA256 // TypeDefIndex: 961
{
	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateSHA256; // 0x38
	private uint[] _W; // 0x40
	private static readonly uint[] _K; // 0x0

	// Methods

	// RVA: 0x26340E0 Offset: 0x26341E1 VA: 0x26340E0
	public void .ctor() { }

	// RVA: 0x2634320 Offset: 0x2634421 VA: 0x2634320 Slot: 16
	public override void Initialize() { }

	// RVA: 0x2634370 Offset: 0x2634471 VA: 0x2634370 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x2634590 Offset: 0x2634691 VA: 0x2634590 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x2634200 Offset: 0x2634301 VA: 0x2634200
	private void InitializeState() { }

	// RVA: 0x2634380 Offset: 0x2634481 VA: 0x2634380
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x26345A0 Offset: 0x26346A1 VA: 0x26345A0
	private byte[] _EndHash() { }

	// RVA: 0x2634770 Offset: 0x2634871 VA: 0x2634770
	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

	// RVA: 0x2635480 Offset: 0x2635581 VA: 0x2635480
	private static uint RotateRight(uint x, int n) { }

	// RVA: 0x26353E0 Offset: 0x26354E1 VA: 0x26353E0
	private static uint Ch(uint x, uint y, uint z) { }

	// RVA: 0x2635460 Offset: 0x2635561 VA: 0x2635460
	private static uint Maj(uint x, uint y, uint z) { }

	// RVA: 0x2635490 Offset: 0x2635591 VA: 0x2635490
	private static uint sigma_0(uint x) { }

	// RVA: 0x2635500 Offset: 0x2635601 VA: 0x2635500
	private static uint sigma_1(uint x) { }

	// RVA: 0x26353F0 Offset: 0x26354F1 VA: 0x26353F0
	private static uint Sigma_0(uint x) { }

	// RVA: 0x2635370 Offset: 0x2635471 VA: 0x2635370
	private static uint Sigma_1(uint x) { }

	// RVA: 0x2635200 Offset: 0x2635301 VA: 0x2635200
	private static void SHA256Expand(uint* x) { }

	// RVA: 0x2635570 Offset: 0x2635671 VA: 0x2635570
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xB0270 Offset: 0xB0371 VA: 0xB0270
public class SHA256Managed : SHA256 // TypeDefIndex: 961
{
	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateSHA256; // 0x38
	private uint[] _W; // 0x40
	private static readonly uint[] _K; // 0x0

	// Methods

	// RVA: 0x26340E0 Offset: 0x26341E1 VA: 0x26340E0
	public void .ctor() { }

	// RVA: 0x2634320 Offset: 0x2634421 VA: 0x2634320 Slot: 16
	public override void Initialize() { }

	// RVA: 0x2634370 Offset: 0x2634471 VA: 0x2634370 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x2634590 Offset: 0x2634691 VA: 0x2634590 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x2634200 Offset: 0x2634301 VA: 0x2634200
	private void InitializeState() { }

	// RVA: 0x2634380 Offset: 0x2634481 VA: 0x2634380
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x26345A0 Offset: 0x26346A1 VA: 0x26345A0
	private byte[] _EndHash() { }

	// RVA: 0x2634770 Offset: 0x2634871 VA: 0x2634770
	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

	// RVA: 0x2635480 Offset: 0x2635581 VA: 0x2635480
	private static uint RotateRight(uint x, int n) { }

	// RVA: 0x26353E0 Offset: 0x26354E1 VA: 0x26353E0
	private static uint Ch(uint x, uint y, uint z) { }

	// RVA: 0x2635460 Offset: 0x2635561 VA: 0x2635460
	private static uint Maj(uint x, uint y, uint z) { }

	// RVA: 0x2635490 Offset: 0x2635591 VA: 0x2635490
	private static uint sigma_0(uint x) { }

	// RVA: 0x2635500 Offset: 0x2635601 VA: 0x2635500
	private static uint sigma_1(uint x) { }

	// RVA: 0x26353F0 Offset: 0x26354F1 VA: 0x26353F0
	private static uint Sigma_0(uint x) { }

	// RVA: 0x2635370 Offset: 0x2635471 VA: 0x2635370
	private static uint Sigma_1(uint x) { }

	// RVA: 0x2635200 Offset: 0x2635301 VA: 0x2635200
	private static void SHA256Expand(uint* x) { }

	// RVA: 0x2635570 Offset: 0x2635671 VA: 0x2635570
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xB0270 Offset: 0xB0371 VA: 0xB0270
public class SHA256Managed : SHA256 // TypeDefIndex: 961
{
	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateSHA256; // 0x38
	private uint[] _W; // 0x40
	private static readonly uint[] _K; // 0x0

	// Methods

	// RVA: 0x26340E0 Offset: 0x26341E1 VA: 0x26340E0
	public void .ctor() { }

	// RVA: 0x2634320 Offset: 0x2634421 VA: 0x2634320 Slot: 16
	public override void Initialize() { }

	// RVA: 0x2634370 Offset: 0x2634471 VA: 0x2634370 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x2634590 Offset: 0x2634691 VA: 0x2634590 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x2634200 Offset: 0x2634301 VA: 0x2634200
	private void InitializeState() { }

	// RVA: 0x2634380 Offset: 0x2634481 VA: 0x2634380
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x26345A0 Offset: 0x26346A1 VA: 0x26345A0
	private byte[] _EndHash() { }

	// RVA: 0x2634770 Offset: 0x2634871 VA: 0x2634770
	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

	// RVA: 0x2635480 Offset: 0x2635581 VA: 0x2635480
	private static uint RotateRight(uint x, int n) { }

	// RVA: 0x26353E0 Offset: 0x26354E1 VA: 0x26353E0
	private static uint Ch(uint x, uint y, uint z) { }

	// RVA: 0x2635460 Offset: 0x2635561 VA: 0x2635460
	private static uint Maj(uint x, uint y, uint z) { }

	// RVA: 0x2635490 Offset: 0x2635591 VA: 0x2635490
	private static uint sigma_0(uint x) { }

	// RVA: 0x2635500 Offset: 0x2635601 VA: 0x2635500
	private static uint sigma_1(uint x) { }

	// RVA: 0x26353F0 Offset: 0x26354F1 VA: 0x26353F0
	private static uint Sigma_0(uint x) { }

	// RVA: 0x2635370 Offset: 0x2635471 VA: 0x2635370
	private static uint Sigma_1(uint x) { }

	// RVA: 0x2635200 Offset: 0x2635301 VA: 0x2635200
	private static void SHA256Expand(uint* x) { }

	// RVA: 0x2635570 Offset: 0x2635671 VA: 0x2635570
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xB0270 Offset: 0xB0371 VA: 0xB0270
public class SHA256Managed : SHA256 // TypeDefIndex: 961
{
	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateSHA256; // 0x38
	private uint[] _W; // 0x40
	private static readonly uint[] _K; // 0x0

	// Methods

	// RVA: 0x26340E0 Offset: 0x26341E1 VA: 0x26340E0
	public void .ctor() { }

	// RVA: 0x2634320 Offset: 0x2634421 VA: 0x2634320 Slot: 16
	public override void Initialize() { }

	// RVA: 0x2634370 Offset: 0x2634471 VA: 0x2634370 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x2634590 Offset: 0x2634691 VA: 0x2634590 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x2634200 Offset: 0x2634301 VA: 0x2634200
	private void InitializeState() { }

	// RVA: 0x2634380 Offset: 0x2634481 VA: 0x2634380
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x26345A0 Offset: 0x26346A1 VA: 0x26345A0
	private byte[] _EndHash() { }

	// RVA: 0x2634770 Offset: 0x2634871 VA: 0x2634770
	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

	// RVA: 0x2635480 Offset: 0x2635581 VA: 0x2635480
	private static uint RotateRight(uint x, int n) { }

	// RVA: 0x26353E0 Offset: 0x26354E1 VA: 0x26353E0
	private static uint Ch(uint x, uint y, uint z) { }

	// RVA: 0x2635460 Offset: 0x2635561 VA: 0x2635460
	private static uint Maj(uint x, uint y, uint z) { }

	// RVA: 0x2635490 Offset: 0x2635591 VA: 0x2635490
	private static uint sigma_0(uint x) { }

	// RVA: 0x2635500 Offset: 0x2635601 VA: 0x2635500
	private static uint sigma_1(uint x) { }

	// RVA: 0x26353F0 Offset: 0x26354F1 VA: 0x26353F0
	private static uint Sigma_0(uint x) { }

	// RVA: 0x2635370 Offset: 0x2635471 VA: 0x2635370
	private static uint Sigma_1(uint x) { }

	// RVA: 0x2635200 Offset: 0x2635301 VA: 0x2635200
	private static void SHA256Expand(uint* x) { }

	// RVA: 0x2635570 Offset: 0x2635671 VA: 0x2635570
	private static void .cctor() { }
}

