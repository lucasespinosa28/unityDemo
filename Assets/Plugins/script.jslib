// File:script.jslib

mergeInto(LibraryManager.library, {
  SendTranscationFromUnity:function (address,amount) {
    ReactUnityWebGL.SendTranscationFromUnity(Pointer_stringify(address), amount);
  },
});