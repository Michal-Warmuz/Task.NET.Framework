/**
 * This view is an example list of people.
 */
Ext.define('Task.view.main.List', {
    extend: 'Ext.grid.Panel',
    xtype: 'mainlist',

    requires: [
        'Task.store.Personnel'
    ],

    title: 'Rezerwacje',

    store: {
        type: 'personnel'
    },

    columns: [
        { text: 'Kod',  dataIndex: 'Code',flex: 1 },
        { text: 'Data utworzenia',  dataIndex: 'CreatedAt',flex: 1 },
        { text: 'Cena', dataIndex: 'Price', flex: 1 },
        { text: 'Waluta', dataIndex: 'Currency', flex: 1 },
        { text: 'Data zameldowania', dataIndex: 'CheckInDate', flex: 1 },
        { text: 'Data wymeldowania', dataIndex: 'CheckOutDate', flex: 1 },
        { text: 'Prowizja', dataIndex: 'Provision', flex: 1 },
        { text: 'Źródło', dataIndex: 'Source', flex: 1 }
    ],

    listeners: {
        select: 'onItemSelected'
    }
});
