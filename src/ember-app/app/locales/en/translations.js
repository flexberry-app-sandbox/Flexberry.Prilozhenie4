import $ from 'jquery';
import EmberFlexberryTranslations from 'ember-flexberry/locales/en/translations';

import IISPrilozhenieДокПланЗаНаДLForm from './forms/i-i-s-prilozhenie-док-план-за-на-д-l';
import IISPrilozhenieСпрВидыРабLForm from './forms/i-i-s-prilozhenie-спр-виды-раб-l';
import IISPrilozhenieСпрЕдИзмерLForm from './forms/i-i-s-prilozhenie-спр-ед-измер-l';
import IISPrilozhenieСпрКонтрАгLForm from './forms/i-i-s-prilozhenie-спр-контр-аг-l';
import IISPrilozhenieСпрНоменLForm from './forms/i-i-s-prilozhenie-спр-номен-l';
import IISPrilozhenieСпрОбъектСтрLForm from './forms/i-i-s-prilozhenie-спр-объект-стр-l';
import IISPrilozhenieСпрПользовLForm from './forms/i-i-s-prilozhenie-спр-пользов-l';
import IISPrilozhenieСпрТипТрансСрLForm from './forms/i-i-s-prilozhenie-спр-тип-транс-ср-l';
import IISPrilozhenieСпрТранспСрLForm from './forms/i-i-s-prilozhenie-спр-трансп-ср-l';
import IISPrilozhenieДокПланЗаНаДEForm from './forms/i-i-s-prilozhenie-док-план-за-на-д-e';
import IISPrilozhenieСпрВидыРабEForm from './forms/i-i-s-prilozhenie-спр-виды-раб-e';
import IISPrilozhenieСпрЕдИзмерEForm from './forms/i-i-s-prilozhenie-спр-ед-измер-e';
import IISPrilozhenieСпрКонтрАгEForm from './forms/i-i-s-prilozhenie-спр-контр-аг-e';
import IISPrilozhenieСпрНоменEForm from './forms/i-i-s-prilozhenie-спр-номен-e';
import IISPrilozhenieСпрОбъектСтрEForm from './forms/i-i-s-prilozhenie-спр-объект-стр-e';
import IISPrilozhenieСпрПользовEForm from './forms/i-i-s-prilozhenie-спр-пользов-e';
import IISPrilozhenieСпрТипТрансСрEForm from './forms/i-i-s-prilozhenie-спр-тип-транс-ср-e';
import IISPrilozhenieСпрТранспСрEForm from './forms/i-i-s-prilozhenie-спр-трансп-ср-e';
import IISPrilozhenieДокПланЗаНаДModel from './models/i-i-s-prilozhenie-док-план-за-на-д';
import IISPrilozhenieСпрВидыРабModel from './models/i-i-s-prilozhenie-спр-виды-раб';
import IISPrilozhenieСпрЕдИзмерModel from './models/i-i-s-prilozhenie-спр-ед-измер';
import IISPrilozhenieСпрКонтрАгModel from './models/i-i-s-prilozhenie-спр-контр-аг';
import IISPrilozhenieСпрНоменModel from './models/i-i-s-prilozhenie-спр-номен';
import IISPrilozhenieСпрОбъектСтрModel from './models/i-i-s-prilozhenie-спр-объект-стр';
import IISPrilozhenieСпрПользовModel from './models/i-i-s-prilozhenie-спр-пользов';
import IISPrilozhenieСпрТипТрансСрModel from './models/i-i-s-prilozhenie-спр-тип-транс-ср';
import IISPrilozhenieСпрТранспСрModel from './models/i-i-s-prilozhenie-спр-трансп-ср';

const translations = {};
$.extend(true, translations, EmberFlexberryTranslations);

$.extend(true, translations, {
  models: {
    'i-i-s-prilozhenie-док-план-за-на-д': IISPrilozhenieДокПланЗаНаДModel,
    'i-i-s-prilozhenie-спр-виды-раб': IISPrilozhenieСпрВидыРабModel,
    'i-i-s-prilozhenie-спр-ед-измер': IISPrilozhenieСпрЕдИзмерModel,
    'i-i-s-prilozhenie-спр-контр-аг': IISPrilozhenieСпрКонтрАгModel,
    'i-i-s-prilozhenie-спр-номен': IISPrilozhenieСпрНоменModel,
    'i-i-s-prilozhenie-спр-объект-стр': IISPrilozhenieСпрОбъектСтрModel,
    'i-i-s-prilozhenie-спр-пользов': IISPrilozhenieСпрПользовModel,
    'i-i-s-prilozhenie-спр-тип-транс-ср': IISPrilozhenieСпрТипТрансСрModel,
    'i-i-s-prilozhenie-спр-трансп-ср': IISPrilozhenieСпрТранспСрModel
  },

  'application-name': 'Prilozhenie',

  forms: {
    loading: {
      'spinner-caption': 'Loading stuff, please wait for a moment...'
    },
    index: {
      greeting: 'Welcome to ember-flexberry test stand!'
    },

    application: {
      header: {
        menu: {
          'sitemap-button': {
            title: 'Menu'
          },
          'user-settings-service-checkbox': {
            caption: 'Use service to save user settings'
          },
          'show-menu': {
            caption: 'Show menu'
          },
          'hide-menu': {
            caption: 'Hide menu'
          },
          'language-dropdown': {
            caption: 'Application language',
            placeholder: 'Choose language'
          }
        },
        login: {
          caption: 'Login'
        },
        logout: {
          caption: 'Logout'
        }
      },

      footer: {
        'application-name': 'Prilozhenie',
        'application-version': {
          caption: 'Addon version {{version}}',
          title: 'It is version of ember-flexberry addon, which uses in this dummy application ' +
          '(npm version + commit sha). ' +
          'Click to open commit on GitHub.'
        }
      },

      sitemap: {
        'application-name': {
          caption: 'Prilozhenie',
          title: 'Prilozhenie'
        },
        'application-version': {
          caption: 'Addon version {{version}}',
          title: 'It is version of ember-flexberry addon, which uses in this dummy application ' +
          '(npm version + commit sha). ' +
          'Click to open commit on GitHub.'
        },
        index: {
          caption: 'Home',
          title: ''
        },
        prilozhenie: {
          caption: 'Prilozhenie',
          title: 'Prilozhenie',
          'i-i-s-prilozhenie-спр-контр-аг-l': {
            caption: 'Справочник контрагенты',
            title: ''
          },
          'i-i-s-prilozhenie-спр-тип-транс-ср-l': {
            caption: 'Справочник типы транспортного средства',
            title: ''
          },
          'i-i-s-prilozhenie-спр-пользов-l': {
            caption: 'Справочник пользователи',
            title: ''
          },
          'i-i-s-prilozhenie-спр-виды-раб-l': {
            caption: 'Справочник виды работ',
            title: ''
          },
          'i-i-s-prilozhenie-спр-объект-стр-l': {
            caption: 'Справочник объекты строительства',
            title: ''
          },
          'i-i-s-prilozhenie-спр-номен-l': {
            caption: 'Справочник номенклатура',
            title: ''
          },
          'i-i-s-prilozhenie-спр-ед-измер-l': {
            caption: 'Справочник единицы измерения',
            title: ''
          },
          'i-i-s-prilozhenie-спр-трансп-ср-l': {
            caption: 'Справочник транспортные средства',
            title: ''
          },
          'i-i-s-prilozhenie-док-план-за-на-д-l': {
            caption: 'Документ плановая заявка на день',
            title: ''
          }
        }
      }
    },

    'edit-form': {
      'save-success-message-caption': 'Save operation succeed',
      'save-success-message': 'Object saved',
      'save-error-message-caption': 'Save operation failed',
      'delete-success-message-caption': 'Delete operation succeed',
      'delete-success-message': 'Object deleted',
      'delete-error-message-caption': 'Delete operation failed'
    },
    'i-i-s-prilozhenie-док-план-за-на-д-l': IISPrilozhenieДокПланЗаНаДLForm,
    'i-i-s-prilozhenie-спр-виды-раб-l': IISPrilozhenieСпрВидыРабLForm,
    'i-i-s-prilozhenie-спр-ед-измер-l': IISPrilozhenieСпрЕдИзмерLForm,
    'i-i-s-prilozhenie-спр-контр-аг-l': IISPrilozhenieСпрКонтрАгLForm,
    'i-i-s-prilozhenie-спр-номен-l': IISPrilozhenieСпрНоменLForm,
    'i-i-s-prilozhenie-спр-объект-стр-l': IISPrilozhenieСпрОбъектСтрLForm,
    'i-i-s-prilozhenie-спр-пользов-l': IISPrilozhenieСпрПользовLForm,
    'i-i-s-prilozhenie-спр-тип-транс-ср-l': IISPrilozhenieСпрТипТрансСрLForm,
    'i-i-s-prilozhenie-спр-трансп-ср-l': IISPrilozhenieСпрТранспСрLForm,
    'i-i-s-prilozhenie-док-план-за-на-д-e': IISPrilozhenieДокПланЗаНаДEForm,
    'i-i-s-prilozhenie-спр-виды-раб-e': IISPrilozhenieСпрВидыРабEForm,
    'i-i-s-prilozhenie-спр-ед-измер-e': IISPrilozhenieСпрЕдИзмерEForm,
    'i-i-s-prilozhenie-спр-контр-аг-e': IISPrilozhenieСпрКонтрАгEForm,
    'i-i-s-prilozhenie-спр-номен-e': IISPrilozhenieСпрНоменEForm,
    'i-i-s-prilozhenie-спр-объект-стр-e': IISPrilozhenieСпрОбъектСтрEForm,
    'i-i-s-prilozhenie-спр-пользов-e': IISPrilozhenieСпрПользовEForm,
    'i-i-s-prilozhenie-спр-тип-транс-ср-e': IISPrilozhenieСпрТипТрансСрEForm,
    'i-i-s-prilozhenie-спр-трансп-ср-e': IISPrilozhenieСпрТранспСрEForm
  },

});

export default translations;
