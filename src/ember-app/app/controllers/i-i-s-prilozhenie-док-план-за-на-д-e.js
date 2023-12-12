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

      }
    }

    return cellComponent;
  },
});
