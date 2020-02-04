/**
 * This view is an example list of people.
 */
Ext.define('Task.view.main.List', {
    extend: 'Ext.grid.Grid',
    xtype: 'mainlist',

    requires: [
        'Task.store.Personnel'
    ],

    title: 'Personnel',

    store: {
        type: 'personnel'
    },

    columns: [{ 
        text: 'Kod',
        dataIndex: 'code',
        width: 100,
        cell: {
            userCls: 'bold'
        }
    }, {
        text: 'Cena',
        dataIndex: 'price',
        width: 230 
    }, { 
        text: 'Waluta',
        dataIndex: 'currency',
        width: 150 
    }],

    listeners: {
        select: 'onItemSelected'
    }
});
