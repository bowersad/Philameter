$(function	()	{
	var ridershipPerDay = 333600;
	
	$(window).load(function(e)	{
	
		//Initial Animations
		var d = new Date();
		var dayStart = new Date(d.getFullYear(),d.getMonth(),d.getDate());
		var monthStart = new Date(d.getFullYear(),d.getMonth(),1);
		var yearStart = new Date(d.getFullYear(),1,1);		

		var currentSeptaDaily = ((d - dayStart) / 86400000) * ridershipPerDay;
		$({numberValue: 0}).animate({numberValue: currentSeptaDaily}, {
			duration: 1000,
			easing: 'linear',
			step: function() { 
				$('#septaDaily').text(Math.ceil(this.numberValue)); 
			}
		});
		
		var currentSeptaMonthly =  ((d - monthStart) / 86400000) * ridershipPerDay;		
		$({numberValue: 0}).animate({numberValue: currentSeptaMonthly}, {
			duration: 2000,
			easing: 'linear',
			step: function() { 
				$('#septaMonthly').text(Math.ceil(this.numberValue)); 
			}
		});
			
		var currentSeptaAnnually =  ((d - yearStart) / 86400000) * ridershipPerDay;		
		$({numberValue: 0}).animate({numberValue: currentSeptaAnnually}, {
			duration: 4000,
			easing: 'linear',
			step: function() { 
				$('#septaAnnually').text(Math.ceil(this.numberValue)); 
			}
		});
	
	
		setInterval(function() {
			var currentNumber = $('#septaDaily').text();
			var d = new Date();
			var dayStart = new Date(d.getFullYear(),d.getMonth(),d.getDate());
			var newNumber = ((d - dayStart) / 86400000) * ridershipPerDay;

			$({numberValue: currentNumber}).animate({numberValue: newNumber}, {
				duration: 500,
				easing: 'linear',
				step: function() { 
					$('#septaDaily').text(Math.ceil(this.numberValue)); 
				}
			});
		}, 2000);
			
		setInterval(function() {
			var currentNumber = $('#septaMonthly').text();

			var d = new Date();
			var monthStart = new Date(d.getFullYear(),d.getMonth(),1);
			var time = d.getTime();
			var newNumber = ((d - monthStart) / 86400000) * ridershipPerDay;
			$({numberValue: currentNumber}).animate({numberValue: newNumber}, {
				duration: 1500,
				easing: 'linear',
				step: function() { 
					$('#septaMonthly').text(Math.ceil(this.numberValue)); 
				}
			});
		}, 4500);

		setInterval(function() {
			var currentNumber = $('#septaAnnually').text();

			var d = new Date();
			var yearStart = new Date(d.getFullYear(),1,1);
			var time = d.getTime();
			var newNumber = ((d - yearStart) / 86400000) * ridershipPerDay;
			$({numberValue: currentNumber}).animate({numberValue: newNumber}, {
				duration: 2500,
				easing: 'linear',
				step: function() { 
					$('#septaAnnually').text(Math.ceil(this.numberValue)); 
				}
			});
		}, 8500);					
		
	});
});
