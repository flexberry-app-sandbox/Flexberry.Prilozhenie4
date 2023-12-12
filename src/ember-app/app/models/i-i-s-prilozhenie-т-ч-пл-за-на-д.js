import { buildValidations } from 'ember-cp-validations';
import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

import {
  defineProjections,
  ValidationRules,
  Model as ТЧПлЗаНаДMixin
} from '../mixins/regenerated/models/i-i-s-prilozhenie-т-ч-пл-за-на-д';

const Validations = buildValidations(ValidationRules, {
  dependentKeys: ['model.i18n.locale'],
});

let Model = EmberFlexberryDataModel.extend(ТЧПлЗаНаДMixin, Validations, {
});

defineProjections(Model);

export default Model;
