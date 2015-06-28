$(function	()	{

	var pretzelsPerDay = 63821;
	
	$(window).load(function(e)	{
	
		//Initial Animations
		var d = new Date();
		var dayStart = new Date(d.getFullYear(),d.getMonth(),d.getDate());
		var monthStart = new Date(d.getFullYear(),d.getMonth(),1);
		var yearStart = new Date(d.getFullYear(),1,1);		

		var currentPretzelDaily = ((d - dayStart) / 86400000) * pretzelsPerDay;
		$({numberValue: 0}).animate({numberValue: currentPretzelDaily}, {
			duration: 1000,
			easing: 'linear',
			step: function() { 
				$('#pretzelDaily').text(Math.ceil(this.numberValue)); 
			}
		});

		var currentPretzelMonthly =  ((d - monthStart) / 86400000) * pretzelsPerDay;		
		$({numberValue: 0}).animate({numberValue: currentPretzelMonthly}, {
			duration: 2000,
			easing: 'linear',
			step: function() { 
				$('#pretzelMonthly').text(Math.ceil(this.numberValue)); 
			}
		});
			
		var currentPretzelAnnually =  ((d - yearStart) / 86400000) * pretzelsPerDay;		
		$({numberValue: 0}).animate({numberValue: currentPretzelAnnually}, {
			duration: 4000,
			easing: 'linear',
			step: function() { 
				$('#pretzelAnnually').text(Math.ceil(this.numberValue)); 
			}
		});		
	

		setInterval(function() {
			var currentNumber = $('#pretzelDaily').text();
			var d = new Date();
			var dayStart = new Date(d.getFullYear(),d.getMonth(),d.getDate());
			var newNumber = ((d - dayStart) / 86400000) * pretzelsPerDay;

			$({numberValue: currentNumber}).animate({numberValue: newNumber}, {
				duration: 500,
				easing: 'linear',
				step: function() { 
					$('#pretzelDaily').text(Math.ceil(this.numberValue)); 
				}
			});
		}, 2000);	

		setInterval(function() {
			var currentNumber = $('#pretzelMonthly').text();

			var d = new Date();
			var monthStart = new Date(d.getFullYear(),d.getMonth(),1);
			var time = d.getTime();
			var newNumber = ((d - monthStart) / 86400000) * pretzelsPerDay;
			$({numberValue: currentNumber}).animate({numberValue: newNumber}, {
				duration: 1500,
				easing: 'linear',
				step: function() { 
					$('#pretzelMonthly').text(Math.ceil(this.numberValue)); 
				}
			});
		}, 4500);

		setInterval(function() {
			var currentNumber = $('#pretzelAnnually').text();

			var d = new Date();
			var yearStart = new Date(d.getFullYear(),1,1);
			var time = d.getTime();
			var newNumber = ((d - yearStart) / 86400000) * pretzelsPerDay;
			$({numberValue: currentNumber}).animate({numberValue: newNumber}, {
				duration: 2500,
				easing: 'linear',
				step: function() { 
					$('#pretzelAnnually').text(Math.ceil(this.numberValue)); 
				}
			});
		}, 8500);					
		
	});
});
