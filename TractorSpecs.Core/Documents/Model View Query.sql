select * from model
join make 
on make.makeId = model.makeId
join equipmentClass 
on equipmentClass.equipmentClassID = model.equipmentClassId
join specification
on specification.modelId = model.modelId
join specName
on specName.specNameId = specification.specNameId
join specClass
on specClass.specClassID = specName.specClassId
where modelUrl = 'L210'
order by sp

select * from equipmentClass

select * from specClass

--All class information for a specification
select * from specClass
join specName 
on specClass.specClassID = specName.specClassId
where specClass.specClassID = 14