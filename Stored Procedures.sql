use banque
-- la procedure pour le depot
create procedure spDepot(@numCompte int,@montant decimal)
as
begin
   declare @Error int=0;
   --if the account doesnt exist
   if(not exists(select * from Compte where Num_Compte=@numCompte))
   begin 
	  print 'this account doesnt exist'
	  set @Error=1
	end
	-- if is exists 
	-- we begin a transaction inside a try catch 
	-- so if there is any error we will roll back the transaction 
	begin try
	  begin transaction 
	     update Compte set Solde=Solde+@montant
		 where Num_Compte=@numCompte;
		 insert into Mouvement values(@numCompte,@montant,'dépôt',GETDATE());
		 if(@Error<>0)
		    begin
		     rollback transaction
			 return 1
		    end
          else 
		    begin
		     print 'job done'
		     commit transaction
			 return 0
            end
	end try
	begin catch
	     print 'there was an error'
		 rollback transaction
		 return 2
	end catch
end


-- la procedure pour le Retrait
create procedure spRetrait(@numCompte int,@montant decimal)
as
begin
   declare @Error int=0;
   --if the account doesnt exist
   if(not exists(select * from Compte where Num_Compte=@numCompte))
     begin 
	   print 'this account doesnt exist'
	   set @Error=1
	 end
	--if the the account doesnt have enough money 
	if(@montant>(select Solde from Compte where Num_Compte=@numCompte))
	  begin
	    print 'there is no enough money'
		set @Error=3
	  end
	-- if is exists and has enough money
	-- we begin a transaction inside a try catch 
	-- so if there is any error we will roll back the transaction 
	begin try
	  begin transaction 
	     update Compte set Solde=Solde-@montant
		 where Num_Compte=@numCompte;
		 insert into Mouvement values(@numCompte,@montant,'retrait',GETDATE());
		 if(@Error<>0)
		    begin
		      rollback transaction
			  return @Error
		    end
          else 
		    begin
		      print 'job done'
		      commit transaction
			  return 0
            end
	end try
	begin catch
	     print 'there was an error'
		 rollback transaction
		 return 2
	end catch
end

-- la procedure verer
create procedure spVerer(@numDebiteur int,@numCrediteur int,@montant decimal)
as
begin
    declare @Error int=0;
	begin try
	  begin transaction
	    --check if both accounts are exists
	    if(not exists(select * from Compte where Num_Compte=@numDebiteur))
		 begin
		  print 'the debtor doesnt exists';
		  set @Error=1;
		 end
		if(not exists(select * from Compte where Num_Compte=@numCrediteur))
		 begin
		  print 'the cridit doesnt exists';
		  set @Error=4
		 end   
       -- check if the debtor has enough money
		if(@montant>(select Solde from Compte where Num_Compte=@numDebiteur))
		 begin
		  print 'the debtor desnt have enough money';
		  return 3
		 end
		 -- decrement the debtor sold
		 update Compte set Solde=Solde-@montant
		 where Num_Compte=@numDebiteur
		 -- increment the credit sold
		 update Compte set Solde=Solde+@montant
		 where Num_Compte=@numCrediteur
		 -- add a new row to virement
		 insert into Virement values(@numDebiteur,@numCrediteur,@montant,GETDATE());
		 if(@Error<>0)
		   begin
		     rollback transaction
			 return @Error
		   end
         else
		   begin
		     commit transaction
			 print 'job done'
			 return 0
		   end
    end try
    begin catch
      print 'there is an error'
	  rollback transaction
	  return 2
    end catch
end