/*
 * This file launches the application by asking Ext JS to create
 * and launch() the Application class.
 */
Ext.application({
    extend: 'Task.Application',

    name: 'Task',

    requires: [
        // This will automatically load all classes in the Task namespace
        // so that application classes do not need to require each other.
        'Task.*'
    ],

    // The name of the initial view to create.
    mainView: 'Task.view.main.Main'
});
