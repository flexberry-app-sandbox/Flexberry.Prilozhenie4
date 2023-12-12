import EditFormController from 'ember-flexberry/controllers/edit-form';

export default EditFormController.extend({
  parentRoute: 'i-i-s-prilozhenie-док-план-за-на-д-l',

  getCellComponent(attr, bindingPath, model) {
    let cellComponent = this._super(...arguments);
    if (attr.kind === 'belongsTo') {
      switch (`${model.modelName}+${bindingPath}`) {
        case 'i-i-s-prilozhenie-т-ч-пл-за-на-д+спрНомен':
          cellComponent.componentProperties = {
            choose: 'showLookupDialog',
            remove: 'removeLookupValue',
            displayAttributeName: 'номенклатура',
            required: true,
            relationName: 'спрНомен',
            projection: 'СпрНоменL',
            autocomplete: true,
          };
          break;

        case 'i-i-s-prilozhenie-т-ч-пл-за-на-д+спрКонтрАг':
          cellComponent.componentProperties = {
            choose: 'showLookupDialog',
            remove: 'removeLookupValue',
            displayAttributeName: 'контрагенты',
            required: true,
            relationName: 'спрКонтрАг',
            projection: 'СпрКонтрАгL',
            autocomplete: true,
          };
          break;

        case 'i-i-s-prilozhenie-т-ч-пл-за-на-д+спрВидыРаб':
          cellComponent.componentProperties = {
            choose: 'showLookupDialog',
            remove: 'removeLookupValue',
            displayAttributeName: 'виды работы',
            required: true,
            relationName: 'спрВидыРаб',
            projection: 'СпрВидыРабL',
            autocomplete: true,
          };
          break;

        case 'i-i-s-prilozhenie-т-ч-пл-за-на-д+спрТранспСр':
          cellComponent.componentProperties = {
            choose: 'showLookupDialog',
            remove: 'removeLookupValue',
            displayAttributeName: 'транспортное средство',
            required: true,
            relationName: 'спрТранспСр',
            projection: 'СпрТранспСрL',
            autocomplete: true,
          };
          break;

        case 'i-i-s-prilozhenie-т-ч-пл-за-на-д+спрТипТрансСр':
          cellComponent.componentProperties = {
            choose: 'showLookupDialog',
            remove: 'removeLookupValue',
            displayAttributeName: 'типы транспортного средства',
            required: true,
            relationName: 'спрТипТрансСр',
            projection: 'СпрТипТрансСрL',
            autocomplete: true,
          };
          break;

        case 'i-i-s-prilozhenie-т-ч-пл-за-на-д+спрЕдИзмер':
          cellComponent.componentProperties = {
            choose: 'showLookupDialog',
            remove: 'removeLookupValue',
            displayAttributeName: 'единицы измерения',
            required: true,
            relationName: 'спрЕдИзмер',
            projection: 'СпрЕдИзмерL',
            autocomplete: true,
          };
          break;

      }
    }

    return cellComponent;
  },
});
