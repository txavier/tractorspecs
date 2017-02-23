select * from specName
join specification
on specification.specNameId = specName.specNameId
join model
on specification.modelId = model.modelId
join specClass
on specClass.specClassID = specName.specClassId
where displayName = 'Cold-cranking amps'

select * from specName
left outer join specClass
on specClass.specClassID = specName.specClassId
where displayName = 'Cold-cranking amps'

select * from specClass
join specName 
on specClass.specClassID = specName.specClassId
where specClass.specClassID = 14
where displayName = 'Cold-cranking amps'
