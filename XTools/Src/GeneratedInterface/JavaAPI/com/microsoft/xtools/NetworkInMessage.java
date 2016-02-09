/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.microsoft.xtools;

public class NetworkInMessage {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected NetworkInMessage(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(NetworkInMessage obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        XToolsClientJNI.delete_NetworkInMessage(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public short ReadByte() {
    return XToolsClientJNI.NetworkInMessage_ReadByte(swigCPtr, this);
  }

  public short ReadInt16() {
    return XToolsClientJNI.NetworkInMessage_ReadInt16(swigCPtr, this);
  }

  public int ReadInt32() {
    return XToolsClientJNI.NetworkInMessage_ReadInt32(swigCPtr, this);
  }

  public long ReadInt64() {
    return XToolsClientJNI.NetworkInMessage_ReadInt64(swigCPtr, this);
  }

  public float ReadFloat() {
    return XToolsClientJNI.NetworkInMessage_ReadFloat(swigCPtr, this);
  }

  public double ReadDouble() {
    return XToolsClientJNI.NetworkInMessage_ReadDouble(swigCPtr, this);
  }

  public XString ReadString() {
	// ref_ptr by value javaout
    long cPtr = XToolsClientJNI.NetworkInMessage_ReadString(swigCPtr, this);
    return (cPtr == 0) ? null : new XString(cPtr, true);
  }

  public void ReadArray(byte[] data, long arrayLength) {
    XToolsClientJNI.NetworkInMessage_ReadArray(swigCPtr, this, data, arrayLength);
  }

  public int GetUnreadBitsCount() {
    return XToolsClientJNI.NetworkInMessage_GetUnreadBitsCount(swigCPtr, this);
  }

  public int GetSize() {
    return XToolsClientJNI.NetworkInMessage_GetSize(swigCPtr, this);
  }

}