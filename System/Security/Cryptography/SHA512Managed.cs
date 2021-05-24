[ComVisibleAttribute] // RVA: 0xB02F0 Offset: 0xB03F1 VA: 0xB02F0
public class SHA512Managed : SHA512 // TypeDefIndex: 965
{
	// Fields
	private byte[] _buffer; // 0x28
	private ulong _count; // 0x30
	private ulong[] _stateSHA512; // 0x38
	private ulong[] _W; // 0x40
	private static readonly ulong[] _K; // 0x0

	// Methods

	// RVA: 0x2636EA0 Offset: 0x2636FA1 VA: 0x2636EA0
	public void .ctor() { }

	// RVA: 0x2637120 Offset: 0x2637221 VA: 0x2637120 Slot: 16
	public override void Initialize() { }

	// RVA: 0x2637170 Offset: 0x2637271 VA: 0x2637170 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x2637390 Offset: 0x2637491 VA: 0x2637390 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x2636FC0 Offset: 0x26370C1 VA: 0x2636FC0
	private void InitializeState() { }

	// RVA: 0x2637180 Offset: 0x2637281 VA: 0x2637180
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x26373A0 Offset: 0x26374A1 VA: 0x26373A0
	private byte[] _EndHash() { }

	// RVA: 0x2637570 Offset: 0x2637671 VA: 0x2637570
	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	// RVA: 0x2638280 Offset: 0x2638381 VA: 0x2638280
	private static ulong RotateRight(ulong x, int n) { }

	// RVA: 0x26381E0 Offset: 0x26382E1 VA: 0x26381E0
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	// RVA: 0x2638260 Offset: 0x2638361 VA: 0x2638260
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	// RVA: 0x26381F0 Offset: 0x26382F1 VA: 0x26381F0
	private static ulong Sigma_0(ulong x) { }

	// RVA: 0x2638170 Offset: 0x2638271 VA: 0x2638170
	private static ulong Sigma_1(ulong x) { }

	// RVA: 0x2638290 Offset: 0x2638391 VA: 0x2638290
	private static ulong sigma_0(ulong x) { }

	// RVA: 0x2638300 Offset: 0x2638401 VA: 0x2638300
	private static ulong sigma_1(ulong x) { }

	// RVA: 0x2638000 Offset: 0x2638101 VA: 0x2638000
	private static void SHA512Expand(ulong* x) { }

	// RVA: 0x2638370 Offset: 0x2638471 VA: 0x2638370
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xB02F0 Offset: 0xB03F1 VA: 0xB02F0
public class SHA512Managed : SHA512 // TypeDefIndex: 965
{
	// Fields
	private byte[] _buffer; // 0x28
	private ulong _count; // 0x30
	private ulong[] _stateSHA512; // 0x38
	private ulong[] _W; // 0x40
	private static readonly ulong[] _K; // 0x0

	// Methods

	// RVA: 0x2636EA0 Offset: 0x2636FA1 VA: 0x2636EA0
	public void .ctor() { }

	// RVA: 0x2637120 Offset: 0x2637221 VA: 0x2637120 Slot: 16
	public override void Initialize() { }

	// RVA: 0x2637170 Offset: 0x2637271 VA: 0x2637170 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x2637390 Offset: 0x2637491 VA: 0x2637390 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x2636FC0 Offset: 0x26370C1 VA: 0x2636FC0
	private void InitializeState() { }

	// RVA: 0x2637180 Offset: 0x2637281 VA: 0x2637180
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x26373A0 Offset: 0x26374A1 VA: 0x26373A0
	private byte[] _EndHash() { }

	// RVA: 0x2637570 Offset: 0x2637671 VA: 0x2637570
	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	// RVA: 0x2638280 Offset: 0x2638381 VA: 0x2638280
	private static ulong RotateRight(ulong x, int n) { }

	// RVA: 0x26381E0 Offset: 0x26382E1 VA: 0x26381E0
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	// RVA: 0x2638260 Offset: 0x2638361 VA: 0x2638260
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	// RVA: 0x26381F0 Offset: 0x26382F1 VA: 0x26381F0
	private static ulong Sigma_0(ulong x) { }

	// RVA: 0x2638170 Offset: 0x2638271 VA: 0x2638170
	private static ulong Sigma_1(ulong x) { }

	// RVA: 0x2638290 Offset: 0x2638391 VA: 0x2638290
	private static ulong sigma_0(ulong x) { }

	// RVA: 0x2638300 Offset: 0x2638401 VA: 0x2638300
	private static ulong sigma_1(ulong x) { }

	// RVA: 0x2638000 Offset: 0x2638101 VA: 0x2638000
	private static void SHA512Expand(ulong* x) { }

	// RVA: 0x2638370 Offset: 0x2638471 VA: 0x2638370
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xB02F0 Offset: 0xB03F1 VA: 0xB02F0
public class SHA512Managed : SHA512 // TypeDefIndex: 965
{
	// Fields
	private byte[] _buffer; // 0x28
	private ulong _count; // 0x30
	private ulong[] _stateSHA512; // 0x38
	private ulong[] _W; // 0x40
	private static readonly ulong[] _K; // 0x0

	// Methods

	// RVA: 0x2636EA0 Offset: 0x2636FA1 VA: 0x2636EA0
	public void .ctor() { }

	// RVA: 0x2637120 Offset: 0x2637221 VA: 0x2637120 Slot: 16
	public override void Initialize() { }

	// RVA: 0x2637170 Offset: 0x2637271 VA: 0x2637170 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x2637390 Offset: 0x2637491 VA: 0x2637390 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x2636FC0 Offset: 0x26370C1 VA: 0x2636FC0
	private void InitializeState() { }

	// RVA: 0x2637180 Offset: 0x2637281 VA: 0x2637180
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x26373A0 Offset: 0x26374A1 VA: 0x26373A0
	private byte[] _EndHash() { }

	// RVA: 0x2637570 Offset: 0x2637671 VA: 0x2637570
	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	// RVA: 0x2638280 Offset: 0x2638381 VA: 0x2638280
	private static ulong RotateRight(ulong x, int n) { }

	// RVA: 0x26381E0 Offset: 0x26382E1 VA: 0x26381E0
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	// RVA: 0x2638260 Offset: 0x2638361 VA: 0x2638260
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	// RVA: 0x26381F0 Offset: 0x26382F1 VA: 0x26381F0
	private static ulong Sigma_0(ulong x) { }

	// RVA: 0x2638170 Offset: 0x2638271 VA: 0x2638170
	private static ulong Sigma_1(ulong x) { }

	// RVA: 0x2638290 Offset: 0x2638391 VA: 0x2638290
	private static ulong sigma_0(ulong x) { }

	// RVA: 0x2638300 Offset: 0x2638401 VA: 0x2638300
	private static ulong sigma_1(ulong x) { }

	// RVA: 0x2638000 Offset: 0x2638101 VA: 0x2638000
	private static void SHA512Expand(ulong* x) { }

	// RVA: 0x2638370 Offset: 0x2638471 VA: 0x2638370
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xB02F0 Offset: 0xB03F1 VA: 0xB02F0
public class SHA512Managed : SHA512 // TypeDefIndex: 965
{
	// Fields
	private byte[] _buffer; // 0x28
	private ulong _count; // 0x30
	private ulong[] _stateSHA512; // 0x38
	private ulong[] _W; // 0x40
	private static readonly ulong[] _K; // 0x0

	// Methods

	// RVA: 0x2636EA0 Offset: 0x2636FA1 VA: 0x2636EA0
	public void .ctor() { }

	// RVA: 0x2637120 Offset: 0x2637221 VA: 0x2637120 Slot: 16
	public override void Initialize() { }

	// RVA: 0x2637170 Offset: 0x2637271 VA: 0x2637170 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x2637390 Offset: 0x2637491 VA: 0x2637390 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x2636FC0 Offset: 0x26370C1 VA: 0x2636FC0
	private void InitializeState() { }

	// RVA: 0x2637180 Offset: 0x2637281 VA: 0x2637180
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x26373A0 Offset: 0x26374A1 VA: 0x26373A0
	private byte[] _EndHash() { }

	// RVA: 0x2637570 Offset: 0x2637671 VA: 0x2637570
	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	// RVA: 0x2638280 Offset: 0x2638381 VA: 0x2638280
	private static ulong RotateRight(ulong x, int n) { }

	// RVA: 0x26381E0 Offset: 0x26382E1 VA: 0x26381E0
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	// RVA: 0x2638260 Offset: 0x2638361 VA: 0x2638260
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	// RVA: 0x26381F0 Offset: 0x26382F1 VA: 0x26381F0
	private static ulong Sigma_0(ulong x) { }

	// RVA: 0x2638170 Offset: 0x2638271 VA: 0x2638170
	private static ulong Sigma_1(ulong x) { }

	// RVA: 0x2638290 Offset: 0x2638391 VA: 0x2638290
	private static ulong sigma_0(ulong x) { }

	// RVA: 0x2638300 Offset: 0x2638401 VA: 0x2638300
	private static ulong sigma_1(ulong x) { }

	// RVA: 0x2638000 Offset: 0x2638101 VA: 0x2638000
	private static void SHA512Expand(ulong* x) { }

	// RVA: 0x2638370 Offset: 0x2638471 VA: 0x2638370
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xB02F0 Offset: 0xB03F1 VA: 0xB02F0
public class SHA512Managed : SHA512 // TypeDefIndex: 965
{
	// Fields
	private byte[] _buffer; // 0x28
	private ulong _count; // 0x30
	private ulong[] _stateSHA512; // 0x38
	private ulong[] _W; // 0x40
	private static readonly ulong[] _K; // 0x0

	// Methods

	// RVA: 0x2636EA0 Offset: 0x2636FA1 VA: 0x2636EA0
	public void .ctor() { }

	// RVA: 0x2637120 Offset: 0x2637221 VA: 0x2637120 Slot: 16
	public override void Initialize() { }

	// RVA: 0x2637170 Offset: 0x2637271 VA: 0x2637170 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x2637390 Offset: 0x2637491 VA: 0x2637390 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x2636FC0 Offset: 0x26370C1 VA: 0x2636FC0
	private void InitializeState() { }

	// RVA: 0x2637180 Offset: 0x2637281 VA: 0x2637180
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x26373A0 Offset: 0x26374A1 VA: 0x26373A0
	private byte[] _EndHash() { }

	// RVA: 0x2637570 Offset: 0x2637671 VA: 0x2637570
	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	// RVA: 0x2638280 Offset: 0x2638381 VA: 0x2638280
	private static ulong RotateRight(ulong x, int n) { }

	// RVA: 0x26381E0 Offset: 0x26382E1 VA: 0x26381E0
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	// RVA: 0x2638260 Offset: 0x2638361 VA: 0x2638260
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	// RVA: 0x26381F0 Offset: 0x26382F1 VA: 0x26381F0
	private static ulong Sigma_0(ulong x) { }

	// RVA: 0x2638170 Offset: 0x2638271 VA: 0x2638170
	private static ulong Sigma_1(ulong x) { }

	// RVA: 0x2638290 Offset: 0x2638391 VA: 0x2638290
	private static ulong sigma_0(ulong x) { }

	// RVA: 0x2638300 Offset: 0x2638401 VA: 0x2638300
	private static ulong sigma_1(ulong x) { }

	// RVA: 0x2638000 Offset: 0x2638101 VA: 0x2638000
	private static void SHA512Expand(ulong* x) { }

	// RVA: 0x2638370 Offset: 0x2638471 VA: 0x2638370
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xB02F0 Offset: 0xB03F1 VA: 0xB02F0
public class SHA512Managed : SHA512 // TypeDefIndex: 965
{
	// Fields
	private byte[] _buffer; // 0x28
	private ulong _count; // 0x30
	private ulong[] _stateSHA512; // 0x38
	private ulong[] _W; // 0x40
	private static readonly ulong[] _K; // 0x0

	// Methods

	// RVA: 0x2636EA0 Offset: 0x2636FA1 VA: 0x2636EA0
	public void .ctor() { }

	// RVA: 0x2637120 Offset: 0x2637221 VA: 0x2637120 Slot: 16
	public override void Initialize() { }

	// RVA: 0x2637170 Offset: 0x2637271 VA: 0x2637170 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x2637390 Offset: 0x2637491 VA: 0x2637390 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x2636FC0 Offset: 0x26370C1 VA: 0x2636FC0
	private void InitializeState() { }

	// RVA: 0x2637180 Offset: 0x2637281 VA: 0x2637180
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x26373A0 Offset: 0x26374A1 VA: 0x26373A0
	private byte[] _EndHash() { }

	// RVA: 0x2637570 Offset: 0x2637671 VA: 0x2637570
	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	// RVA: 0x2638280 Offset: 0x2638381 VA: 0x2638280
	private static ulong RotateRight(ulong x, int n) { }

	// RVA: 0x26381E0 Offset: 0x26382E1 VA: 0x26381E0
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	// RVA: 0x2638260 Offset: 0x2638361 VA: 0x2638260
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	// RVA: 0x26381F0 Offset: 0x26382F1 VA: 0x26381F0
	private static ulong Sigma_0(ulong x) { }

	// RVA: 0x2638170 Offset: 0x2638271 VA: 0x2638170
	private static ulong Sigma_1(ulong x) { }

	// RVA: 0x2638290 Offset: 0x2638391 VA: 0x2638290
	private static ulong sigma_0(ulong x) { }

	// RVA: 0x2638300 Offset: 0x2638401 VA: 0x2638300
	private static ulong sigma_1(ulong x) { }

	// RVA: 0x2638000 Offset: 0x2638101 VA: 0x2638000
	private static void SHA512Expand(ulong* x) { }

	// RVA: 0x2638370 Offset: 0x2638471 VA: 0x2638370
	private static void .cctor() { }
}

