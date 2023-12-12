import Controller from '@ember/controller';
import { computed } from '@ember/object';

export default Controller.extend({
  sitemap: computed('i18n.locale', function () {
    let i18n = this.get('i18n');

    return {
      nodes: [
        {
          link: 'index',
          icon: 'home',
          caption: i18n.t('forms.application.sitemap.index.caption'),
          title: i18n.t('forms.application.sitemap.index.title'),
          children: null
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.prilozhenie.caption'),
          title: i18n.t('forms.application.sitemap.prilozhenie.title'),
          children: [{
            link: 'i-i-s-prilozhenie-спр-контр-аг-l',
            caption: i18n.t('forms.application.sitemap.prilozhenie.i-i-s-prilozhenie-спр-контр-аг-l.caption'),
            title: i18n.t('forms.application.sitemap.prilozhenie.i-i-s-prilozhenie-спр-контр-аг-l.title'),
            icon: 'building',
            children: null
          }, {
            link: 'i-i-s-prilozhenie-спр-тип-транс-ср-l',
            caption: i18n.t('forms.application.sitemap.prilozhenie.i-i-s-prilozhenie-спр-тип-транс-ср-l.caption'),
            title: i18n.t('forms.application.sitemap.prilozhenie.i-i-s-prilozhenie-спр-тип-транс-ср-l.title'),
            icon: 'archive',
            children: null
          }, {
            link: 'i-i-s-prilozhenie-спр-пользов-l',
            caption: i18n.t('forms.application.sitemap.prilozhenie.i-i-s-prilozhenie-спр-пользов-l.caption'),
            title: i18n.t('forms.application.sitemap.prilozhenie.i-i-s-prilozhenie-спр-пользов-l.title'),
            icon: 'building',
            children: null
          }, {
            link: 'i-i-s-prilozhenie-спр-виды-раб-l',
            caption: i18n.t('forms.application.sitemap.prilozhenie.i-i-s-prilozhenie-спр-виды-раб-l.caption'),
            title: i18n.t('forms.application.sitemap.prilozhenie.i-i-s-prilozhenie-спр-виды-раб-l.title'),
            icon: 'suitcase',
            children: null
          }, {
            link: 'i-i-s-prilozhenie-спр-объект-стр-l',
            caption: i18n.t('forms.application.sitemap.prilozhenie.i-i-s-prilozhenie-спр-объект-стр-l.caption'),
            title: i18n.t('forms.application.sitemap.prilozhenie.i-i-s-prilozhenie-спр-объект-стр-l.title'),
            icon: 'folder open',
            children: null
          }, {
            link: 'i-i-s-prilozhenie-спр-номен-l',
            caption: i18n.t('forms.application.sitemap.prilozhenie.i-i-s-prilozhenie-спр-номен-l.caption'),
            title: i18n.t('forms.application.sitemap.prilozhenie.i-i-s-prilozhenie-спр-номен-l.title'),
            icon: 'chart bar',
            children: null
          }, {
            link: 'i-i-s-prilozhenie-спр-ед-измер-l',
            caption: i18n.t('forms.application.sitemap.prilozhenie.i-i-s-prilozhenie-спр-ед-измер-l.caption'),
            title: i18n.t('forms.application.sitemap.prilozhenie.i-i-s-prilozhenie-спр-ед-измер-l.title'),
            icon: 'tags',
            children: null
          }, {
            link: 'i-i-s-prilozhenie-спр-трансп-ср-l',
            caption: i18n.t('forms.application.sitemap.prilozhenie.i-i-s-prilozhenie-спр-трансп-ср-l.caption'),
            title: i18n.t('forms.application.sitemap.prilozhenie.i-i-s-prilozhenie-спр-трансп-ср-l.title'),
            icon: 'tasks',
            children: null
          }, {
            link: 'i-i-s-prilozhenie-док-план-за-на-д-l',
            caption: i18n.t('forms.application.sitemap.prilozhenie.i-i-s-prilozhenie-док-план-за-на-д-l.caption'),
            title: i18n.t('forms.application.sitemap.prilozhenie.i-i-s-prilozhenie-док-план-за-на-д-l.title'),
            icon: 'tags',
            children: null
          }]
        }
      ]
    };
  }),
})