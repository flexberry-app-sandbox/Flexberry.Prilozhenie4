import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  время: DS.attr('string'),
  дата: DS.attr('date'),
  номер: DS.attr('number'),
  спрКонтрАг: DS.belongsTo('i-i-s-prilozhenie-спр-контр-аг', { inverse: null, async: false }),
  спрОбъектСтр: DS.belongsTo('i-i-s-prilozhenie-спр-объект-стр', { inverse: null, async: false }),
  спрПользов: DS.belongsTo('i-i-s-prilozhenie-спр-пользов', { inverse: null, async: false }),
  тЧПлЗаНаД: DS.hasMany('i-i-s-prilozhenie-т-ч-пл-за-на-д', { inverse: 'докПланЗаНаД', async: false })
});

export let ValidationRules = {
  время: {
    descriptionKey: 'models.i-i-s-prilozhenie-док-план-за-на-д.validations.время.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  дата: {
    descriptionKey: 'models.i-i-s-prilozhenie-док-план-за-на-д.validations.дата.__caption__',
    validators: [
      validator('ds-error'),
      validator('date'),
    ],
  },
  номер: {
    descriptionKey: 'models.i-i-s-prilozhenie-док-план-за-на-д.validations.номер.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  спрКонтрАг: {
    descriptionKey: 'models.i-i-s-prilozhenie-док-план-за-на-д.validations.спрКонтрАг.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  спрОбъектСтр: {
    descriptionKey: 'models.i-i-s-prilozhenie-док-план-за-на-д.validations.спрОбъектСтр.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  спрПользов: {
    descriptionKey: 'models.i-i-s-prilozhenie-док-план-за-на-д.validations.спрПользов.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  тЧПлЗаНаД: {
    descriptionKey: 'models.i-i-s-prilozhenie-док-план-за-на-д.validations.тЧПлЗаНаД.__caption__',
    validators: [
      validator('ds-error'),
      validator('has-many'),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ДокПланЗаНаДE', 'i-i-s-prilozhenie-док-план-за-на-д', {
    номер: attr('Номер', { index: 0 }),
    дата: attr('Дата', { index: 1 }),
    время: attr('Время', { index: 2 }),
    спрКонтрАг: belongsTo('i-i-s-prilozhenie-спр-контр-аг', 'Организация', {
      наименование: attr('Организация', { index: 4 })
    }, { index: 3 }),
    спрОбъектСтр: belongsTo('i-i-s-prilozhenie-спр-объект-стр', 'Объект строительства', {
      наименование: attr('Объект строительства', { index: 6 })
    }, { index: 5 }),
    спрПользов: belongsTo('i-i-s-prilozhenie-спр-пользов', 'Автор', {
      фИО: attr('Автор', { index: 8 })
    }, { index: 7 }),
    тЧПлЗаНаД: hasMany('i-i-s-prilozhenie-т-ч-пл-за-на-д', 'План задач на день', {
      стЗатрат: attr('Статья затрат', { index: 0 }),
      спрНомен: belongsTo('i-i-s-prilozhenie-спр-номен', 'Номенклатура', {
        наименование: attr('Имя номенклатуры', { index: 2 })
      }, { index: 1, displayMemberPath: 'имя номенклатуры' }),
      спрКонтрАг: belongsTo('i-i-s-prilozhenie-спр-контр-аг', 'Контрагент', {
        наименование: attr('Контрагент', { index: 4 })
      }, { index: 3, displayMemberPath: 'контрагент' }),
      спрВидыРаб: belongsTo('i-i-s-prilozhenie-спр-виды-раб', 'Виды работы', {
        наименование: attr('Виды работы', { index: 6 })
      }, { index: 5 }),
      объемРаботы: attr('Объем работы', { index: 7 }),
      спрТранспСр: belongsTo('i-i-s-prilozhenie-спр-трансп-ср', 'Транспортное средство', {
        наименование: attr('Транспортное средство', { index: 9 })
      }, { index: 8 }),
      спрТипТрансСр: belongsTo('i-i-s-prilozhenie-спр-тип-транс-ср', 'Тип транспортного средства', {
        наименование: attr('Тип транспортного средства', { index: 11 })
      }, { index: 10 }),
      врПрибытия: attr('Время прибытия', { index: 12 }),
      колЧасРаб: attr('Количество часов работы', { index: 13 }),
      обГруз: attr('Объем груза', { index: 14 }),
      спрЕдИзмер: belongsTo('i-i-s-prilozhenie-спр-ед-измер', 'Единица измерения', {
        наименование: attr('Единица измерения', { index: 16 })
      }, { index: 15 })
    })
  });

  modelClass.defineProjection('ДокПланЗаНаДL', 'i-i-s-prilozhenie-док-план-за-на-д', {
    номер: attr('Номер', { index: 0 }),
    дата: attr('Дата', { index: 1 }),
    время: attr('Время', { index: 2 }),
    спрКонтрАг: belongsTo('i-i-s-prilozhenie-спр-контр-аг', 'Организация', {
      наименование: attr('Организация', { index: 3 })
    }, { index: -1, hidden: true }),
    спрОбъектСтр: belongsTo('i-i-s-prilozhenie-спр-объект-стр', 'Объект строительства', {
      наименование: attr('Объект строительства', { index: 4 })
    }, { index: -1, hidden: true }),
    спрПользов: belongsTo('i-i-s-prilozhenie-спр-пользов', 'Автор', {
      фИО: attr('Автор', { index: 5 })
    }, { index: -1, hidden: true })
  });
};
