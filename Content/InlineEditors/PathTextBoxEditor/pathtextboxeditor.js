(function () {
    window.kentico.pageBuilder.registerInlineEditor("path-text-box-editor", {
        init: function (options) {
            var editor = options.editor;
            var box = editor.querySelector("#path-box");
            if (box !== null) {
                box.addEventListener("blur", function () {
                    var event = new CustomEvent("updateProperty", {
                        detail: {
                            value: box.value,
                            name: options.propertyName
                        }
                    });
                    editor.dispatchEvent(event);
                });
            }
        }
    });
})();