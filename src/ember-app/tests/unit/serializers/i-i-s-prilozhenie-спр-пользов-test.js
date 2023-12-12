import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-prilozhenie-спр-пользов', 'Unit | Serializer | i-i-s-prilozhenie-спр-пользов', {
  // Specify the other units that are required for this test.
  needs: [
    'serializer:i-i-s-prilozhenie-спр-пользов',
    'service:syncer',
    'transform:file',
    'transform:decimal',
    'transform:guid',

    'model:i-i-s-prilozhenie-док-план-за-на-д',
    'model:i-i-s-prilozhenie-спр-виды-раб',
    'model:i-i-s-prilozhenie-спр-ед-измер',
    'model:i-i-s-prilozhenie-спр-контр-аг',
    'model:i-i-s-prilozhenie-спр-номен',
    'model:i-i-s-prilozhenie-спр-объект-стр',
    'model:i-i-s-prilozhenie-спр-пользов',
    'model:i-i-s-prilozhenie-спр-тип-транс-ср',
    'model:i-i-s-prilozhenie-спр-трансп-ср',
    'model:i-i-s-prilozhenie-т-ч-пл-за-на-д',
    'validator:ds-error',
    'validator:presence',
    'validator:number',
    'validator:date',
    'validator:belongs-to',
    'validator:has-many',
  ],
});

// Replace this with your real tests.
test('it serializes records', function(assert) {
  let record = this.subject();

  let serializedRecord = record.serialize();

  assert.ok(serializedRecord);
});
