using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiStyleMod
    {
        public ImGuiStyleVar VarIdx;
        public UnionValue Value;
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
        public ref UnionValue Value => ref Unsafe.AsRef<UnionValue>(&NativePtr->Value);
        public void Destroy()
        {
            ImGuiNative.ImGuiStyleMod_destroy(NativePtr);
        }
    }
}
