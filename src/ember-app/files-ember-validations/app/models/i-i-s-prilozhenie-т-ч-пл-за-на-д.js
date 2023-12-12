import {
  defineNamespace,
  defineProjections,
  Model as ТЧПлЗаНаДMixin
} from '../mixins/regenerated/models/i-i-s-prilozhenie-т-ч-пл-за-на-д';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(ТЧПлЗаНаДMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
