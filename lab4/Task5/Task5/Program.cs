using Task5;

var document = new TextDocument("Initial State", "Initial Text");
var editor = new TextEditor(document);

editor.Backup();

document.DoSomething();
editor.Backup();

document.DoSomething();
editor.Backup();

editor.ShowHistory();

editor.Undo();

editor.Undo();

editor.ShowHistory();