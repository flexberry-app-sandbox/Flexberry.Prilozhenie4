import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-prilozhenie-спр-номен', 'Unit | Model | i-i-s-prilozhenie-спр-номен', {
  // Specify the other units that are required for this test.
  needs: [
    'model:i-i-s-prilozhenie-док-план-за-на-д',
    'model:i-i-s-prilozhenie-спр-виды-раб',
    'model:i-i-s-prilozhenie-спр-ед-измер',
    'model:i-i-s-prilozhenie-спр-контр-аг',
    'model:i-i-s-prilozhenie-спр-номен',
    'model:i-i-s-prilozhenie-спр-объект-стр',
    'model:i-i-s-prilozhenie-спр-пользов',
    'model:i-i-s-prilozhenie-спр-тип-транс-ср',
    'model:i-i-s-prilozhenie-спр-трансп-ср',
    'validator:ds-error',
    'validator:presence',
    'validator:number',
    'validator:date',
    'validator:belongs-to',
    'validator:has-many',
    'service:syncer',
  ],
});

test('it exists', function(assert) {
  let model = this.subject();

  // let store = this.store();
  assert.ok(!!model);
});
