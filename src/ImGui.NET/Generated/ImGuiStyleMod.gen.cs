using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiStyleMod
    {
        public ImGuiStyleVar VarIdx;
        public union { int BackupInt[2]; float BackupFloat[2];} ;
    }
    public unsafe partial struct ImGuiStyleModPtr
    {
        public ImGuiStyleMod* NativePtr { get; }
        public ImGuiStyleModPtr(ImGuiStyleMod* nativePtr) => NativePtr = nativePtr;
        public ImGuiStyleModPtr(IntPtr nativePtr) => NativePtr = (ImGuiStyleMod*)nativePtr;
        public static implicit operator ImGuiStyleModPtr(ImGuiStyleMod* nativePtr) => new ImGuiStyleModPtr(nativePtr);
        public static implicit operator ImGuiStyleMod* (ImGuiStyleModPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiStyleModPtr(IntPtr nativePtr) => new ImGuiStyleModPtr(nativePtr);
        public ref ImGuiStyleVar VarIdx => ref Unsafe.AsRef<ImGuiStyleVar>(&NativePtr->VarIdx);
        public ref union { int BackupInt[2]; float BackupFloat[2];}  => ref Unsafe.AsRef<union { int BackupInt[2]; float BackupFloat[2];}>(&NativePtr->);
        public void Destroy()
        {
            ImGuiNative.ImGuiStyleMod_destroy(NativePtr);
        }
    }
}
