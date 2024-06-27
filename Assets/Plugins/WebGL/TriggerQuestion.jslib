mergeInto(LibraryManager.library, {
  TriggerQuestion: function () {
    window.dispatchReactUnityEvent("TriggerQuestion", true);
  },
});