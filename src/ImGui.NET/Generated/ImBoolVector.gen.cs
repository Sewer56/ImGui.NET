using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImBoolVector
    {
        public ImVector Storage;
    }
    public unsafe partial struct ImBoolVectorPtr
    {
        public ImBoolVector* NativePtr { get; }
        public ImBoolVectorPtr(ImBoolVector* nativePtr) => NativePtr = nativePtr;
        public ImBoolVectorPtr(IntPtr nativePtr) => NativePtr = (ImBoolVector*)nativePtr;
        public static implicit operator ImBoolVectorPtr(ImBoolVector* nativePtr) => new ImBoolVectorPtr(nativePtr);
        public static implicit operator ImBoolVector* (ImBoolVectorPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImBoolVectorPtr(IntPtr nativePtr) => new ImBoolVectorPtr(nativePtr);
        public ImVector<int> Storage => new ImVector<int>(NativePtr->Storage);
        public void Clear()
        {
            ImGuiNative.ImBoolVector_Clear(NativePtr);
        }
        public void Destroy()
        {
            ImGuiNative.ImBoolVector_destroy(NativePtr);
        }
        public bool GetBit(int n)
        {
            byte ret = ImGuiNative.ImBoolVector_GetBit(NativePtr, n);
            return ret != 0;
        }
        public void Resize(int sz)
        {
            ImGuiNative.ImBoolVector_Resize(NativePtr, sz);
        }
        public void SetBit(int n, bool v)
        {
            byte native_v = v ? (byte)1 : (byte)0;
            ImGuiNative.ImBoolVector_SetBit(NativePtr, n, native_v);
        }
    }
}
