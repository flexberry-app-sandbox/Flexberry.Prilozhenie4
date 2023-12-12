import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  врПрибытия: DS.attr('string'),
  датПрибыт: DS.attr('date'),
  колЧасРаб: DS.attr('decimal'),
  обГруз: DS.attr('decimal'),
  объемРаботы: DS.attr('string'),
  стЗатрат: DS.attr('string'),
  спрВидыРаб: DS.belongsTo('i-i-s-prilozhenie-спр-виды-раб', { inverse: null, async: false }),
  спрЕдИзмер: DS.belongsTo('i-i-s-prilozhenie-спр-ед-измер', { inverse: null, async: false }),
  спрКонтрАг: DS.belongsTo('i-i-s-prilozhenie-спр-контр-аг', { inverse: null, async: false }),
  спрНомен: DS.belongsTo('i-i-s-prilozhenie-спр-номен', { inverse: null, async: false }),
  спрТипТрансСр: DS.belongsTo('i-i-s-prilozhenie-спр-тип-транс-ср', { inverse: null, async: false }),
  спрТранспСр: DS.belongsTo('i-i-s-prilozhenie-спр-трансп-ср', { inverse: null, async: false }),
  докПланЗаНаД: DS.belongsTo('i-i-s-prilozhenie-док-план-за-на-д', { inverse: 'тЧПлЗаНаД', async: false })
});

export let ValidationRules = {
  врПрибытия: {
    descriptionKey: 'models.i-i-s-prilozhenie-т-ч-пл-за-на-д.validations.врПрибытия.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  датПрибыт: {
    descriptionKey: 'models.i-i-s-prilozhenie-т-ч-пл-за-на-д.validations.датПрибыт.__caption__',
    validators: [
      validator('ds-error'),
      validator('date'),
    ],
  },
  колЧасРаб: {
    descriptionKey: 'models.i-i-s-prilozhenie-т-ч-пл-за-на-д.validations.колЧасРаб.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true }),
    ],
  },
  обГруз: {
    descriptionKey: 'models.i-i-s-prilozhenie-т-ч-пл-за-на-д.validations.обГруз.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true }),
    ],
  },
  объемРаботы: {
    descriptionKey: 'models.i-i-s-prilozhenie-т-ч-пл-за-на-д.validations.объемРаботы.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  стЗатрат: {
    descriptionKey: 'models.i-i-s-prilozhenie-т-ч-пл-за-на-д.validations.стЗатрат.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  спрВидыРаб: {
    descriptionKey: 'models.i-i-s-prilozhenie-т-ч-пл-за-на-д.validations.спрВидыРаб.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  спрЕдИзмер: {
    descriptionKey: 'models.i-i-s-prilozhenie-т-ч-пл-за-на-д.validations.спрЕдИзмер.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  спрКонтрАг: {
    descriptionKey: 'models.i-i-s-prilozhenie-т-ч-пл-за-на-д.validations.спрКонтрАг.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  спрНомен: {
    descriptionKey: 'models.i-i-s-prilozhenie-т-ч-пл-за-на-д.validations.спрНомен.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  спрТипТрансСр: {
    descriptionKey: 'models.i-i-s-prilozhenie-т-ч-пл-за-на-д.validations.спрТипТрансСр.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  спрТранспСр: {
    descriptionKey: 'models.i-i-s-prilozhenie-т-ч-пл-за-на-д.validations.спрТранспСр.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  докПланЗаНаД: {
    descriptionKey: 'models.i-i-s-prilozhenie-т-ч-пл-за-на-д.validations.докПланЗаНаД.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ТчПлЗаНаДE', 'i-i-s-prilozhenie-т-ч-пл-за-на-д', {
    стЗатрат: attr('Статья Затрат', { index: 0 }),
    спрНомен: belongsTo('i-i-s-prilozhenie-спр-номен', 'Номенклатура', {
      наименование: attr('Номенклатура', { index: 2 })
    }, { index: 1, displayMemberPath: 'номенклатура' }),
    спрВидыРаб: belongsTo('i-i-s-prilozhenie-спр-виды-раб', 'Виды работы', {
      наименование: attr('Виды работы', { index: 4 })
    }, { index: 3, displayMemberPath: 'виды работы' }),
    спрКонтрАг: belongsTo('i-i-s-prilozhenie-спр-контр-аг', 'Контрагенты', {
      наименование: attr('Контрагенты', { index: 6 })
    }, { index: 5, displayMemberPath: 'контрагенты' }),
    спрТранспСр: belongsTo('i-i-s-prilozhenie-спр-трансп-ср', 'Транспортное средство', {
      наименование: attr('Транспортное средство', { index: 8 })
    }, { index: 7, displayMemberPath: 'транспортное средство' }),
    спрТипТрансСр: belongsTo('i-i-s-prilozhenie-спр-тип-транс-ср', 'Типы транспортного средства', {
      наименование: attr('Типы транспортного средства', { index: 10 })
    }, { index: 9, displayMemberPath: 'типы транспортного средства' }),
    спрЕдИзмер: belongsTo('i-i-s-prilozhenie-спр-ед-измер', 'Единицы измерения', {
      наименование: attr('Единицы измерения', { index: 12 })
    }, { index: 11, displayMemberPath: 'единицы измерения' }),
    объемРаботы: attr('ОбъемРаботы', { index: 13 }),
    врПрибытия: attr('Время Прибытия', { index: 14 }),
    колЧасРаб: attr('Количество часов работы', { index: 15 }),
    обГруз: attr('Объем работы', { index: 16 })
  });
};
